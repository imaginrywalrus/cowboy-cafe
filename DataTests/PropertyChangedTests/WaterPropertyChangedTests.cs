/*

* Author: Kendall Price

* Class name: WaterPropertyChangedTests.cs

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
    public class WaterPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Price"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Calories"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Size"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the ice property invokes property changed for "Ice"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Tests if changing the ice property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Tests if changing the lemon property invokes property changed for "Lemon"
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = true;
            });
        }

        /// <summary>
        /// Tests if changing the lemon property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = true;
            });
        }
    }
}
