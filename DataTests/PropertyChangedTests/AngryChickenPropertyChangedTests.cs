/*

* Author: Natahn Bean

* Edited By: Kendall Price 

* Class name: AngryChickenPropertyChangedTests.cs

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
    public class AngryChickenPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void AngryChickenImplementsINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        /// <summary>
        /// Tests if changing the bread property invokes property changed for "Bread"
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            });
        }

        /// <summary>
        /// Tests if changing the bread property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bread = false;
            });
        }

        /// <summary>
        /// Tests if changing the pickle property invokes property changed for "Pickle"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if changing the pcikle property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Pickle = false;
            });
        }
    }
}
