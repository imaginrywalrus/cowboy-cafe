/*

* Author: Kendall Price

* Class name: CowboyCoffee.cs

* Purpose: A class to represent the Cowboy Coffee Drink

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the cowboy coffee
    /// </summary>
    public class CowboyCoffee: Drink
    {
        private bool decaf = false;
        /// <summary>
        /// gets if the coffee is decaf or not
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }

            set
            {
                decaf = value;
                InvokePropertyChanged("Decaf");
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// gets if there is room for cream in the cowboy coffee
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }

            set
            {
                roomForCream = value;
                InvokePropertyChanged("RoomForCream");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        private bool ice = false;
        /// <summary>
        /// gets the ice in the cowboy coffee
        /// </summary>
        public override bool Ice
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
        /// the price of the cowboy coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// The calories of the cowboy coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// Special Instructions for preperation of cowboy coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Returns tring representation of the drink
        /// </summary>
        /// <returns>the ToString of the size + Decaf or not + " Cowboy Coffee"</returns>
        public override string ToString()
        {
            if (Decaf)
                return Size.ToString() + " Decaf Cowboy Coffee";
            else
                return Size.ToString() + " Cowboy Coffee";

        }
    }
}
