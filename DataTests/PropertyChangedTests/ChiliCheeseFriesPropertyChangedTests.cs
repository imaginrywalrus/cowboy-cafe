/*

* Author: Kendall Price

* Class name: ChiliCheeseFriesPropertyChangedTests.cs

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
    public class ChiliCheeseFriesPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var fry = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fry);
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Price"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var fry = new ChiliCheeseFries();
            Assert.PropertyChanged(fry, "Price", () =>
            {
                fry.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Calories"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var fry = new ChiliCheeseFries();
            Assert.PropertyChanged(fry, "Calories", () =>
            {
                fry.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Size"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var fry = new ChiliCheeseFries();
            Assert.PropertyChanged(fry, "Size", () =>
            {
                fry.Size = Size.Large;
            });
        }
    }
}
