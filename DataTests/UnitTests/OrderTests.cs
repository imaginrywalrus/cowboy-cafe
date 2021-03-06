﻿/*

* Author: Nathan Bean

* Edited By: Kendall Price 

* Class name: OrderTests.cs

* Purpose: Data Tests for the order class

*/
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        public class MockOrderItem: IOrderItem
        {

            public double Price { get; set; }

            public uint Calories { get; set; }

            public List<string> SpecialInstructions { get; set; }
        }

        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order(1);
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order(1);
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToGetEnumerationOfItems()
        {
            var order = new Order(1);
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            Assert.Collection(order.Items,
                item => Assert.Equal(item0, item),
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item));
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0, 0, 0 })]
        [InlineData(new double[] { 199.34, 799 })]
        [InlineData(new double[] { 798 })]
        [InlineData(new double[] {  })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { -4, 10, 8 })]
        [InlineData(new double[] { 3.1345234262 })]
        [InlineData(new double[] { double.NaN })]
        public void SubtotalShouldBeSumOfItemPrices(double[] prices)
        {
            var order = new Order(1);
            double total = 0;
            foreach (var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }

        [Theory]
        [InlineData("Items")]
        [InlineData("Subtotal")]
        public void AddingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order(1);
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        [Theory]
        [InlineData("Items")]
        [InlineData("Subtotal")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order(1);
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }

        [Fact]
        public void OrderNumberShouldBeRandom()
        {
            var order = new Order(1);
            var order1 = new Order(1);
            Assert.NotEqual(order.OrderNumber, order1.OrderNumber);
        }
    }
}
