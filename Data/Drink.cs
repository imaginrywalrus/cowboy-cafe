/*

* Author: Kendall Price

* Class name: Drink.cs

* Purpose: A base class for Drinks

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a Drink
    /// </summary>
    public abstract class Drink: IOrderItem
    {
        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// gets any special instructions for the drink
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get { return new List<string>(); }
            set { }
        }

        /// <summary>
        /// gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// gets if there is any ice in the drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;
    }
}
