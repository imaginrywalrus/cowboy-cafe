/*

* Author: Kendall Price

* Class name: OrderControl.xaml.cs

* Purpose: Main control for different aspects of the menu

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
using CowboyCafe.Data;
using CashRegister;
using CowboyCafe.PointIOfSale;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        CashDrawer drawer;

        /// <summary>
        /// constructor for the order control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            var data = new Order(1);
            this.DataContext = data;
            drawer = new CashDrawer();
            
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            IOrderItem[] iOrder = (IOrderItem[])order.Items;
            if (iOrder.Length != 0)
            {
                var mainWindow = this.FindAncestor<MainWindow>();
                mainWindow.SwapScreen(new TransactionControl(drawer, this));
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order(((Order)DataContext).OrderNumber + 1);
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Swaps the screen to the given customization element
        /// </summary>
        /// <param name="element">The customization screen to be swaped to</param>
        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
