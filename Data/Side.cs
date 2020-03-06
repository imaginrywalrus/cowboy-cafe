﻿/*

* Author: Nathan Bean

* Edited by: Kendall Price

* Class name: Side.cs

* Purpose: A base class for side dishes

*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        /// 
        public virtual event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }
        

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of side if any
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get { return new List<string>(); }
            set { }
        }
    }
}
