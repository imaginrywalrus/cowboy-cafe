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
    public class Order: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        static private uint lastOrderNumber = 0;

        public uint OrderNumber
        {
            get
            {
                uint i = 1;
                while (i == lastOrderNumber)
                {
                    i++;
                }
                lastOrderNumber = i;
                return i;
            }
        }

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

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

        public void Add(IOrderItem item)
        {
            items.Add(item);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
