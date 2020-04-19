/*

* Author: Kendall Price

* Class name: Menu.cs

* Purpose: Gets all items on the menu

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Gets an instance of all items on the menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets an instance of all items on the menu
        /// </summary>
        /// <returns>IEnumerable with all items on the menu</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            IEnumerable<IOrderItem> itemA = Entree();
            IEnumerable<IOrderItem> itemB = Entree();
            IEnumerable<IOrderItem> itemC = Entree();
            return itemA.Concat(itemB).Concat(itemC);
        }

        /// <summary>
        /// Gets all Entrees on the menu
        /// </summary>
        /// <returns>IEnumerable with all entree items on the menu</returns>
        public static IEnumerable<IOrderItem> Entree()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new AngryChicken());
            items.Add(new CowpokeChili());
            items.Add(new DakotaDoubleBurger());
            items.Add(new PecosPulledPork());
            items.Add(new RustlersRibs());
            items.Add(new TexasTripleBurger());
            items.Add(new TrailBurger());
            IEnumerable<IOrderItem> i = items.ToArray();
            return i;
        }

        /// <summary>
        /// Gets all sides on the menu
        /// </summary>
        /// <returns>IEnumerable with all side items on the menu</returns>
        public static IEnumerable<IOrderItem> Side()
        {
             List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new BakedBeans());
            items.Add(new ChiliCheeseFries());
            items.Add(new CornDodgers());
            items.Add(new PanDeCampo());
            IEnumerable<IOrderItem> i = items.ToArray();
            return i;
        }

        /// <summary>
        /// Gets all drinks on the menu
        /// </summary>
        /// <returns>IEnumerable with all drink items on the menu</returns>
        public static IEnumerable<IOrderItem> Drink()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new CowboyCoffee());
            items.Add(new JerkedSoda());
            items.Add(new TexasTea());
            items.Add(new Water());
            IEnumerable<IOrderItem> i = items.ToArray();
            return i;
        }
    }
}
