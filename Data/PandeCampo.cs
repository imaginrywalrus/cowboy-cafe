/*

* Author: Kendall Price

* Class name: PandeCampo.cs

* Purpose: Represents the Pan de Campo side on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan de Campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// The price of the Pan de Campo based on size
        /// </summary>
        public override double Price
        {

            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// The calories of the Pan de Campo based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// Returns the string representation of the side
        /// </summary>
        /// <returns>The ToString of the size + " Pan de Campo"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Pan de Campo";
        }
    }
}
