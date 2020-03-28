/*

* Author: Kendall Price

* Class name: TrailBurgerPropertyChangedTests.cs

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
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void TrailBurgerImplementsINotifyPropertyChanged()
        {
            var burger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        /// <summary>
        /// Tests if changing the bun property invokes property changed for "Bun"
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });
        }

        /// <summary>
        /// Tests if changing the bun property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bun = false;
            });
        }

        /// <summary>
        /// Tests if changing the ketchup property invokes property changed for "Ketchup"
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }

        /// <summary>
        /// Tests if changing the ketchup property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Ketchup = false;
            });
        }

        /// <summary>
        /// Tests if changing the mustard property invokes property changed for "Mustard"
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });
        }

        /// <summary>
        /// Tests if changing the mustard property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mustard = false;
            });
        }

        /// <summary>
        /// Tests if changing the pickle property invokes property changed for "Pickle"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if changing the pickle property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if changing the cheese property invokes property changed for "Cheese"
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if changing the cheese property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }
    }
}
