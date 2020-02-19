/*

* Author: Kendall Price

* Class name: RustlersRibs.cs

* Purpose: Represents the Rustlers Ribs entree on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree.
    /// </summary>
    public class RustlersRibs: Entree
    {
        /// <summary>
        /// The price of the ribs.
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        
        /// <summary>
        /// The calories of the ribs.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string "Rustlers Ribs"</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
