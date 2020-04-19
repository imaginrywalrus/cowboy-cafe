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

        private uint orderNumber;
        /// <summary>
        /// Gets the current order number
        /// </summary>
        public uint OrderNumber
        {
            get { return orderNumber; }
            private set
            {
                if (value != lastOrderNumber)
                {
                    orderNumber = value;
                    lastOrderNumber = value;
                }
                else
                {
                    orderNumber = lastOrderNumber + 1;
                    lastOrderNumber = value;
                }

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
        /// Gets the total for the current order including sales tax
        /// </summary>
        public double Total
        {
            get
            {
                double total = Subtotal * 1.16;
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
        /// Public constructor that initializes the list
        /// </summary>
        /// <param name="i">The current order number</param>
        public Order(uint i)
        {
            items = new List<IOrderItem>();
            OrderNumber = i;
        }

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

        /// <summary>
        /// Calls property changed when an item is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
