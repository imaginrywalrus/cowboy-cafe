/*

* Author: Kendall Price

* Class name: TexasTeaPropertyChagnedTests.cs

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
    public class TexasTeaPropertyChagnedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void TexasTeaImplementsINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Price"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Calories"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the size property invokes property changed for "Size"
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Large;
            });
        }

        /// <summary>
        /// Tests if changing the ice property invokes property changed for "Ice"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });
        }

        /// <summary>
        /// Tests if changing the ice property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }

        /// <summary>
        /// Tests if changing the lemon property invokes property changed for "Lemon"
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = false;
            });
        }

        /// <summary>
        /// Tests if changing the lemon property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }

        /// <summary>
        /// Tests if changing the lemon property invokes property changed for "Sweet"
        /// </summary>
        [Fact]
        public void ChangingSweetPropertyShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = true;
            });
        }
    }
}
