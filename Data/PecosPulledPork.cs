/*

* Author: Kendall Price

* Class name: PecosPulledPork.cs

* Purpose: Represents the Pecos Pulled Pork entree on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// If the pork is topped with pickles.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the pork is topped with bread.
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// The price of the pork.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pork.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the pork.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Pickle) instructions.Add("hold pickle");
                if (!Bread) instructions.Add("hold bread");

                return instructions;
            }
        }
    }
}
