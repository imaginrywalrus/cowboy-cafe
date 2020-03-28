/*

* Author: Kendall Price

* Class name: CowpokeChiliPropertyChangedTests.cs

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
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// Tests if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void CowpokeChiliImplementsINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

        /// <summary>
        /// Tests if changing the cheese property invokes property changed for "Cheese"
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if changing the cheese property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }

        /// <summary>
        /// Tests if changing the sour cream property invokes property changed for "SourCream"
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// Tests if changing the sour cream property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingSourCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// Tests if changing the green onions property invokes property changed for "GreenOnions"
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        /// <summary>
        /// Tests if changing the green onions property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        /// <summary>
        /// Tests if changing the tortilla strips property invokes property changed for "TortillaStrips"
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }

        /// <summary>
        /// Tests if changing the tortilla strips property invokes property changed for "SpecialInstructions"
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }
    }
}
