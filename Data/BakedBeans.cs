/*

* Author: Kendall Price

* Class name: BakedBeans.cs

* Purpose: Represents the Baked Beans side dish from the menu

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Baked Beans side
    /// </summary>
    public class BakedBeans: Side, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event
        /// </summary>
        /// 
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the Baked Beans based on size
        /// </summary>
        public override double Price
        {

            get
            {
                switch (Size)
                {
                    case Size.Large:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.99;
                    case Size.Medium:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.79;
                    case Size.Small:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// The calories of the Baked Beans based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// Returns the string representation of the side
        /// </summary>
        /// <returns>The ToString of the size + "Baked Beans"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Baked Beans";
        }
    }
}
