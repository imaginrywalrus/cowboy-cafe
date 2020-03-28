/*

* Author: Kendall Price

* Class name: JerkedSoda.cs

* Purpose: A class to represent the Jerked Soda Drink

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        private SodaFlavor flavor;
        /// <summary>
        /// the flavor of the jerked soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }

            set
            {
                flavor = value;
                InvokePropertyChanged("Flavor");
            }
        }

        /// <summary>
        /// the price of the jerked soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// The calories of the jerked soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// Special Instructions for preperation of Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of the drink
        /// </summary>
        /// <returns>The ToString of the size + the flavor + " Jerked Soda"</returns>
        public override string ToString()
        {
            switch(Flavor)
            {
                case SodaFlavor.BirchBeer:
                    return Size.ToString() + " Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size.ToString() + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size.ToString() + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size.ToString() + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size.ToString() + " Sarsparilla Jerked Soda";
                default:
                    throw new NotImplementedException("Unknown Flavor.");
            }

        }
    }
}
