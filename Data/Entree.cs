/*

* Author: Kendall Price

* Class name: Entree.cs

* Purpose: A base class for the entree dishes

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public  event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the special instructions of the entree
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get { return new List<string>(); }
            set { }
        }

        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }


        public virtual string Category { get; set; } = "Entree";

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
