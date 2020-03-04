/*

* Author: Kendall Price

* Class name: PecosPulledPork.cs

* Purpose: Represents the Pecos Pulled Pork entree on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork: Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        /// 
        public event PropertyChangedEventHandler PropertyChanged;

        private bool pickle = true;
        /// <summary>
        /// If the pork is topped with pickles.
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }

            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool bread = true;
        /// <summary>
        /// If the pork is topped with bread.
        /// </summary>
        public bool Bread
        {
            get { return bread; }

            set
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

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

        /// <summary>
        /// Returns the string representation of the entree
        /// </summary>
        /// <returns>The string "Pecos Pulled Pork"</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
