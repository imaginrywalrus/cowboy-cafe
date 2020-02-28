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
                Random r = new Random();
                uint i = (uint)r.Next();
                while (i == lastOrderNumber)
                {
                    i = (uint)r.Next();
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
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
    }
}
