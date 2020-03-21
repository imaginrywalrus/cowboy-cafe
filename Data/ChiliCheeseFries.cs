﻿/*

* Author: Nathan Bean

* Edited By: Kendall Price

* Class name: ChiliCheeseFries.cs

* Purpose: Represents the Chili Cheese Fries side on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries: Side, INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the Chili Cheese Fries based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// The calories of the Chili Cheese Fries based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// Returns the string representation of the side
        /// </summary>
        /// <returns>The ToString of the size + "Chili Cheese Fries"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Chili Cheese Fries";
        }
    }
}
