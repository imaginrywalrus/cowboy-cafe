/*

* Author: Kendall Price

* Class name: TexasTripleBurgerPropertyChangedTests.cs

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
    public class TexasTripleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void TexasTripleBurgerImplementsINotifyPropertyChanged()
        {
            var burger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        /// <summary>
        /// Tests if changing the bun property invokes property changed for "Bun"
        /// </summary>
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
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
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if changing the tomato property invokes property changed for "Tomato"
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForTomato()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Tomato", () =>
            {
                burger.Tomato = false;
            });
        }

        /// <summary>
        /// Tests if changing the tomato property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Tomato = false;
            });
        }

        /// <summary>
        /// Tests if changing the lettuce property invokes property changed for "Lettuce"
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForLettuce()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Lettuce", () =>
            {
                burger.Lettuce = false;
            });
        }

        /// <summary>
        /// Tests if changing the lettuce property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Lettuce = false;
            });
        }

        /// <summary>
        /// Tests if changing the mayo property invokes property changed for "Mayo"
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForMayo()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Mayo", () =>
            {
                burger.Mayo = false;
            });
        }

        /// <summary>
        /// Tests if changing the mayo property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mayo = false;
            });
        }

        /// <summary>
        /// Tests if changing the bacon property invokes property changed for "Bacon"
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForBacon()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Bacon", () =>
            {
                burger.Bacon = false;
            });
        }

        /// <summary>
        /// Tests if changing the bacon property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingBaconPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bacon = false;
            });
        }

        /// <summary>
        /// Tests if changing the egg property invokes property changed for "Egg"
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForEgg()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "Egg", () =>
            {
                burger.Egg = false;
            });
        }

        /// <summary>
        /// Tests if changing the egg property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingEggPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TexasTripleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Egg = false;
            });
        }
    }
}
