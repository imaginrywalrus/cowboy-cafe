/*

* Author: Kendall Price

* Class name: CornDodgers.cs

* Purpose: Represents the Corn Dodger side on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Corn Dodgers side
    /// </summary>
    public class CornDodgers: Side, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        /// 
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the Corn Dodgers based on size
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
        /// The calories of the Corn Dodgers based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }

        /// <summary>
        /// Returns the string representation of the side
        /// </summary>
        /// <returns>The ToString of the size + "Corn Dodgers"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Corn Dodgers";
        }
    }
}

