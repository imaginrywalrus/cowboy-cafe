/*

* Author: Kendall Price

* Class name: Drink.cs

* Purpose: A base class for Drinks

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a Drink
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        /// 
        public virtual event PropertyChangedEventHandler PropertyChanged;

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

        private Size size;
        /// <summary>
        /// gets the size of the drink
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// gets if there is any ice in the drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;
    }
}
