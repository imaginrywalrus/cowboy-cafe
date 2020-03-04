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
                data.Add(new AngryChicken());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new CowpokeChili());
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
                data.Add(new PecosPulledPork());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new RustlersRibs());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new DakotaDoubleBurger());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new TexasTripleBurger());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new TrailBurger());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new BakedBeans());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new ChiliCheeseFries());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new CornDodgers());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new PanDeCampo());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new CowboyCoffee());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new JerkedSoda());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new TexasTea());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
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
                data.Add(new Water());
                orderControl.SwapScreen(new CowpokeChiliCustumization());
            }
        }
    }
}
