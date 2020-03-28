/*

* Author: Kendall Price

* Class name: BakedBeansPropertyChangedTests.cs

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
    public class BakedBeansPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Price"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var bean = new BakedBeans();
            Assert.PropertyChanged(bean, "Price", () =>
            {
                bean.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Calories"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var bean = new BakedBeans();
            Assert.PropertyChanged(bean, "Calories", () =>
            {
                bean.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Size"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var bean = new BakedBeans();
            Assert.PropertyChanged(bean, "Size", () =>
            {
                bean.Size = Size.Large;
            });
        }
    }
}
