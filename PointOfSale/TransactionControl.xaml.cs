/*

* Author: Kendall Price

* Class name: TransactionControl.xaml.cs

* Purpose: Displays order information and gets payment from user when an order is completed

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using PointOfSale;
using CowboyCafe.Data;
using PointOfSale.ExtensionMethods;
namespace CowboyCafe.PointIOfSale

{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// The subtotal of the order
        /// </summary>
        private readonly double subtotal;

        /// <summary>
        /// The total of the order including 16% sales tax
        /// </summary>
        private readonly double total;

        /// <summary>
        /// The order number of the order
        /// </summary>
        private readonly uint orderNumber;

        /// <summary>
        /// The date and time that the order is completed
        /// </summary>
        private readonly DateTime date = DateTime.Now;

        /// <summary>
        /// The list of items on the order
        /// </summary>
        private readonly List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Constructer for TransactionControl
        /// </summary>
        /// <param name="order">The Order that is being processed in the transaction</param>
        public TransactionControl(Order order)
        {
            InitializeComponent();
            subtotal = order.Subtotal;
            total = order.Total;
            orderNumber = order.OrderNumber;
            foreach(IOrderItem orderItem in order.Items)
            {
                items.Add(orderItem);
            }
            this.DataContext = order;
        }

        /// <summary>
        /// Click event for the cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            ReturnToOrderScreen();
        }

        /// <summary>
        /// Click event for the pay with cash button -NOT IMPLEMENTED-
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayWithCashButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cash Payment not implemented.");
        }

        /// <summary>
        /// Click event for the pay with credit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayWithCreditButton_Click(object sender, RoutedEventArgs e)
        {
            CardTerminal card = new CardTerminal();
            ResultCode result = card.ProcessTransaction(total);
            switch (result)
            {
                case ResultCode.Success:
                    PrintCreditReceipt();
                    ReturnToOrderScreen();
                    break;
                case ResultCode.CancelledCard:
                    MessageBox.Show(ResultCode.CancelledCard.ToString());
                    break;
                case ResultCode.InsufficentFunds:
                    MessageBox.Show(ResultCode.InsufficentFunds.ToString());
                    break;
                case ResultCode.ReadError:
                    MessageBox.Show(ResultCode.ReadError.ToString());
                    break;
                case ResultCode.UnknownErrror:
                    MessageBox.Show(ResultCode.UnknownErrror.ToString());
                    break;
                default:
                    MessageBox.Show(ResultCode.UnknownErrror.ToString());
                    break;
            }
        }

        /// <summary>
        /// Prints a receipt if the customer paid with credit
        /// </summary>
        private void PrintCreditReceipt()
        {
            //The order number, the current date and time, the individual order items with price and special instructions, the subtotal, the total with tax
            ReceiptPrinter printer = new ReceiptPrinter();
            StringBuilder sb = new StringBuilder();
            foreach (IOrderItem oi in items)
            {
                sb.Append(oi.ToString() + "\n");
                foreach (string si in oi.SpecialInstructions)
                {
                    sb.Append("-" + si + "\n");
                }
            }
            string receipt = String.Format("\nOrder Number: {0}\nDate and Time: {1}\nOrder Items:\n{2}Subtotal: ${3:0.00}\nTotal: ${4:0.00}\nPaid With Credit", orderNumber, date, sb.ToString(), subtotal, total);
            printer.Print(receipt);
            return;
        }

        /// <summary>
        /// prints a receipt if the customer paid with cash
        /// </summary>
        /// <param name="paid">The amount the customer paid</param>
        /// <param name="change">The amount of change given back to the customer</param>
        private void PrintCashReceipt(double paid, double change)
        {
            //The order number, the current date and time, the individual order items with price and special instructions, the subtotal, the total with tax
            ReceiptPrinter printer = new ReceiptPrinter();
            StringBuilder sb = new StringBuilder();
            foreach (IOrderItem oi in items)
            {
                sb.Append(oi.ToString() + "\n");
                foreach (string si in oi.SpecialInstructions)
                {
                    sb.Append("-" + si + "\n");
                }
            }
            string receipt = String.Format("Order Number: {0}\nDate and Time: {1}\nOrder Items:\n{2}Subtotal: ${3}\n" +
                "Total: ${4}\nPaid With Cash\nTotal Paid: ${5:0.00}\nChange Given: ${6:0.00}\n\n", orderNumber, date, sb.ToString(), subtotal, total, paid, change);
            printer.Print(receipt);
            return;
        }

        /// <summary>
        /// Returns to the OrderControl Screen
        /// </summary>
        private void ReturnToOrderScreen()
        {
            var mainWindow = this.FindAncestor<MainWindow>();
            var screen = new OrderControl();
            mainWindow.SwapScreen(screen);
        }
    }
}
