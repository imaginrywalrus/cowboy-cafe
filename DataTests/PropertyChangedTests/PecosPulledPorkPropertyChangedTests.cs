/*

* Author: Kendall Price

* Class name: PecosPulledPorkPropertyChangedTests.cs

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
    public class PecosPulledPorkPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }

        /// <summary>
        /// Tests if changing the pickle property invokes property changed for "Pickle"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if changing the pickle property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });
        }

        /// <summary>
        /// Tests if changing the bread property invokes property changed for "Bread"
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = false;
            });
        }

        /// <summary>
        /// Tests if changing the bread property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });
        }
    }
}
