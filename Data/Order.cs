/*

* Author: Kendall Price

* Class name: Order.cs

* Purpose: Represents an order put into the system

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Represents an order put in the system
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Event for handling change in properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Holds the previous order number
        /// </summary>
        static private uint lastOrderNumber = 0;

        /// <summary>
        /// Gets the current order number and makes it different from the previous number
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                uint i = lastOrderNumber;
                while (i == lastOrderNumber)
                {
                    i++;
                }
                lastOrderNumber = i;
                return i;
            }
        }

        /// <summary>
        /// Gets the subtotal for the current order
        /// </summary>
        public double Subtotal { 
            get {
                double total = 0;
                foreach (IOrderItem order in items)
                {
                    total += order.Price;
                }
                return total;
            }
        }

        /// <summary>
        /// private backing variable to hold menu items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// gets the menu items from the private list
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Adds a given item to the order
        /// </summary>
        /// <param name="item">The item to add to the order</param>
        public void Add(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifyer)
            {
                notifyer.PropertyChanged += OnItemChanged;
            }
            items.Add(item);
            item.PropertyChanged += OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes the give item from the order
        /// </summary>
        /// <param name="item">the item to remove</param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifyer)
            {
                notifyer.PropertyChanged -= OnItemChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}
