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
    /// 
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// 
        /// </summary>
        List<string> SpecialInstructions { get; }

        double Price { get; }
    }
}
