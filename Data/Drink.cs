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
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        /// 
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        public virtual string Category { get; set; } = "Drink";

        /// <summary>
        /// gets any special instructions for the drink
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get { return new List<string>(); }
            set { }
        }

        private Size size = Size.Small;
        /// <summary>
        /// gets the size of the drink
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;
                InvokePropertyChanged("Size");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
            }
        }

        private bool ice = true;
        /// <summary>
        /// gets the ice in the cowboy coffee
        /// </summary>
        public virtual bool Ice
        {
            get { return ice; }

            set
            {
                ice = value;
                InvokePropertyChanged("Ice");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Updates the given property
        /// </summary>
        /// <param name="property">The property to update</param>
        protected void InvokePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
