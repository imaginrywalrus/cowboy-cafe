using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork
    {
        private bool pickle = true;
        /// <summary>
        /// If the pork is topped with pickles.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        private bool bread = true;
        /// <summary>
        /// If the pork is topped with bread.
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// The price of the pork.
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pork.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the pork.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!pickle) instructions.Add("hold pickle");
                if (!bread) instructions.Add("hold bread");

                return instructions;
            }
        }
    }
}
