﻿/*

* Author: Kendall Price

* Class name: TrailBurger.cs

* Purpose: Represents the Trail Burger entree on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trailburger entree.
    /// </summary>
    public class TrailBurger: Entree
    {
        /// <summary>
        /// If the burger is topped with a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the burger is topped with ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the burger is topped with mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the burger is topped with pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the burger is topped with cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
    }
}
