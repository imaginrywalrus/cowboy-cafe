/*

* Author: Kendall Price

* Class name: CornDodgersPropertyChagnedTests.cs

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
    public class CornDodgersPropertyChagnedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void CornDodgersImplementsINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Price"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Price", () =>
            {
                corn.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Calories"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Calories", () =>
            {
                corn.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Size"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = Size.Large;
            });
        }
    }
}
