﻿/*

* Author: Kendall Price

* Class name: CowboyCoffee.cs

* Purpose: A class to represent the Cowboy Coffee Drink

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing the cowboy coffee
    /// </summary>
    public class CowboyCoffee: Drink
    {
        /// <summary>
        /// gets if the coffee is decaf or not
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// gets if there is room for cream in the cowboy coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// gets the ice in the cowboy coffee
        /// </summary>
        public override bool Ice { get; set; } = false;

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
    }
}