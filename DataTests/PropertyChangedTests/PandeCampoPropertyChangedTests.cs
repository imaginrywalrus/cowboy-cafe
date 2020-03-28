/*

* Author: Kendall Price

* Class name: PandeCampoPropertyChangedTests.cs

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
    public class PandeCampoPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void PanDeCampoImplementsINotifyPropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campo);
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Price"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Calories"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Size"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Large;
            });
        }
    }
}
