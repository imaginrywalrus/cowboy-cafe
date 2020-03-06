/*

* Author: Kendall Price

* Class name: Water.cs

* Purpose: A class to represent the Water Drink

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// a class to represent the water drink
    /// </summary>
    public class Water: Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        /// 
        public override event PropertyChangedEventHandler PropertyChanged;

        private bool lemon = false;
        /// <summary>
        /// gets if there is lemon in the water
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }

            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// the price of the Water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// The calories of the Water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Special Instructions for preperation of Water
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
        /// <returns>the ToString of the size + " Water"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
