/*

* Author: Kendall Price

* Class name: OrderSummaryControl.xaml.cs

* Purpose: Represents an order on the menu

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
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data;
using CowboyCafe.PointIOfSale.CustumisationScreen;
using PointOfSale.CustumisationScreen;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Deletes an item from the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    data.Remove((IOrderItem)button.DataContext);
                }

            }
        }

        /// <summary>
        /// Accesses the data context of the selected item and reopens its custimization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AccessItemDataContext(object sender, SelectionChangedEventArgs args)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = ((sender as ListView).SelectedItem as IOrderItem);
                var screen = new FrameworkElement();
                switch (item)
                {
                    case AngryChicken ac:
                        screen = new AngryChickenCustimization();
                        break;
                    case BakedBeans ac:
                        screen = new BakedBeansCustimization();
                        break;
                    case ChiliCheeseFries ac:
                        screen = new ChiliCheeseFriesCustimization();
                        break;
                    case CornDodgers ac:
                        screen = new CornDodgersCustimization();
                        break;
                    case CowboyCoffee ac:
                        screen = new CowboyCoffeeCustimization();
                        break;
                    case CowpokeChili ac:
                        screen = new CowpokeChiliCustumization();
                        break;
                    case DakotaDoubleBurger ac:
                        screen = new DakotaDoubleBurgerCustimization();
                        break;
                    case JerkedSoda ac:
                        screen = new JerkedSodaCustimization();
                        break;
                    case PanDeCampo ac:
                        screen = new PandeCampoCustimization();
                        break;
                    case PecosPulledPork ac:
                        screen = new PecosPulledPorkCustimization();
                        break;
                    case RustlersRibs ac:
                        screen = new RustlersRibsCustimization();
                        break;
                    case TexasTea ac:
                        screen = new TexasTeaCustimization();
                        break;
                    case TexasTripleBurger ac:
                        screen = new TexasTripleBurgerCustimization();
                        break;
                    case TrailBurger ac:
                        screen = new TrailBurgerCustimization();
                        break;
                    case Water ac:
                        screen = new WaterCustimization();
                        break;
                }
                
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
        }
    }
}
