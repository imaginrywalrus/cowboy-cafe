/*

* Author: Kendall Price

* Class name: TexasTea.cs

* Purpose: A class to represent the Texas Tea Drink

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the texas tea drink
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// gets if the tea is sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// gets if there is lemon in the tea
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// the price of the Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// The calories of the Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException("Unknown Size.");
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException("Unknown Size.");
                    }
                }
            }
        }

        /// <summary>
        /// Special Instructions for preperation of Texas Tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Returns tring representation of the drink
        /// </summary>
        /// <returns>the ToString of the size + Sweet or Plain + " Texas Tea"</returns>
        public override string ToString()
        {
            if (Sweet)
                return Size.ToString() + " Texas Sweet Tea";
            else
                return Size.ToString() + " Texas Plain Tea";

        }
    }
}
