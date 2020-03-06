/*

* Author: Kendall Price

* Class name: MenuItemSelectionControl.xaml.cs

* Purpose: Represents the item selection in the menu

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
using PointOfSale.CustumisationScreen;
using PointOfSale.ExtensionMethods;
using CowboyCafe.PointIOfSale.CustumisationScreen;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new AngryChicken();
                var screen = new AngryChickenCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new CowpokeChili();
                var screen = new CowpokeChiliCustumization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new PecosPulledPork();
                var screen = new PecosPulledPorkCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new RustlersRibs();
                var screen = new RustlersRibsCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new DakotaDoubleBurger();
                var screen = new DakotaDoubleBurgerCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new TexasTripleBurger();
                var screen = new TexasTripleBurgerCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new TrailBurger();
                var screen = new TrailBurgerCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen); 
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new BakedBeans();
                var screen = new BakedBeansCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                    var item = new ChiliCheeseFries();
                    var screen = new ChiliCheeseFriesCustimization();
                    screen.DataContext = item;
                    data.Add(item);
                    orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new CornDodgers();
                var screen = new CornDodgersCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPandeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new PanDeCampo();
                var screen = new PandeCampoCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new CowboyCoffee();
                var screen = new CowboyCoffeeCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new JerkedSoda();
                var screen = new JerkedSodaCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new TexasTea();
                var screen = new TexasTeaCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Click event for button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new Water();
                var screen = new WaterCustimization();
                screen.DataContext = item;
                data.Add(item);
                orderControl.SwapScreen(screen);
            }
        }
    }
}
