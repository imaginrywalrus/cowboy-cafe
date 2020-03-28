/*

* Author: Kendall Price

* Class name: CowboyCoffeePropertyChangedTests.cs

* Purpose: Tests to see if INotifyPropertyChanged is working properly

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void CowboyCoffeeImplementsINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Price"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Calories"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Size"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the decaf property invokes property changed for "Decaf"
        /// </summary>
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = false;
            });
        }

        /// <summary>
        /// Tests if changing the room for cream property invokes property changed for "RoomForCream"
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// Tests if changing the room for cream property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// Tests if changing the ice property invokes property changed for "Ice"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = true;
            });
        }

        /// <summary>
        /// Tests if changing the cheese property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
        }
    }
}
