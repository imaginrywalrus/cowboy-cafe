/*

* Author: Kendall Price

* Class name: AngryChicken.cs

* Purpose: Represents the Angry Chicken entree on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    ///  A class representing the Angry Chicken entree.
    /// </summary>
    public class AngryChicken: Entree
    {
        /// <summary>
        /// If the chicken is topped with pickles.
        /// </summary>
        public bool Pickle { get; set; } = true;
        
        /// <summary>
        /// If the chicken is topped with bread.
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// The price of the chicken.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken.
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

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string "Angry Chicken"</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
