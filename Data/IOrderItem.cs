/*

* Author: Kendall Price

* Class name: IOrderItem.cs

* Purpose: An interface to represent order items

*/
using System;
using System.Collections.Generic;
using System.Text;
namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents an order item
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The special instructions of the order item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// the price of the order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// the calories of the order item
        /// </summary>
        uint Calories { get; }

        string Category { get; set; }
    }
}
