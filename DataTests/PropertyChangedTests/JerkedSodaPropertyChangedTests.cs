/*

* Author: Kendall Price

* Class name: JerkedSodaPropertyChangedTests.cs

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
    public class JerkedSodaPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void JerkedSodaImplementsINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Price"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Calories"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Size"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the flavor property invokes property changed for "Flavor"
        /// </summary>
        [Fact]
        public void ChangingFlavorPropertyShouldInvokePropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.RootBeer;
            });
        }

        /// <summary>
        /// Tests if changing the ice property invokes property changed for "Ice"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }

        /// <summary>
        /// Tests if changing the ice property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }
    }
}
