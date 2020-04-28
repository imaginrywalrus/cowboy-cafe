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
        /// Gets all items on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> All
        {
            get
            {
                List<IOrderItem> menu = new List<IOrderItem>();
                IEnumerable<IOrderItem> itemA = Entree;
                foreach (IOrderItem i in itemA)
                {
                    menu.Add(i);
                }
                itemA = Side;
                foreach (IOrderItem i in itemA)
                {
                    menu.Add(i);
                }
                itemA = Drink;
                foreach (IOrderItem i in itemA)
                {
                    menu.Add(i);
                }
                return menu;
            }
        }

        /// <summary>
        /// Gets all Entrees on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Entree
        {
            get
            {
                List<IOrderItem> items = new List<IOrderItem>();
                items.Add(new AngryChicken());
                items.Add(new CowpokeChili());
                items.Add(new DakotaDoubleBurger());
                items.Add(new PecosPulledPork());
                items.Add(new RustlersRibs());
                items.Add(new TexasTripleBurger());
                items.Add(new TrailBurger());
                return items;
            }
        }

        /// <summary>
        /// Gets all sides on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Side
        {
            get
            {
                List<IOrderItem> items = new List<IOrderItem>();
                items.Add(new BakedBeans());
                items.Add(new ChiliCheeseFries());
                items.Add(new CornDodgers());
                items.Add(new PanDeCampo());
                return items;
            }
        }

        /// <summary>
        /// Gets all drinks on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Drink
        {
            get
            {
                List<IOrderItem> items = new List<IOrderItem>();
                items.Add(new CowboyCoffee());
                items.Add(new JerkedSoda());
                items.Add(new TexasTea());
                items.Add(new Water());
                return items;
            }
        }

        /// <summary>
        /// Searches the menu for matching items
        /// </summary>
        /// <param name="menu">The menu items in a given search</param>
        /// <param name="terms">The terms to search for</param>
        /// <returns>The filtered menu</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menu, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return menu;
            foreach (IOrderItem item in All)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the menu based on what category of item is given
        /// </summary>
        /// <param name="menu">The items on the menu for a given search</param>
        /// <param name="category">The given categories to filter with</param>
        /// <returns>The filtered menu</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menu, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return menu;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in menu)
            {
                if(item is Entree && category.Contains("Entree"))
                {
                    results.Add(item);
                }
                else if (item is Side && category.Contains("Side"))
                {
                    results.Add(item);
                }
                else if (item is Drink && category.Contains("Drink"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the menu based on minimum and maximum calories
        /// </summary>
        /// <param name="menu">The menu items in a given search</param>
        /// <param name="min">The mimimum calories</param>
        /// <param name="max">The maximum calories</param>
        /// <returns>The filtered menu</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, int? min, int? max)
        {
            if (min == null && max == null) return menu;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the menu by the given minimum and maximum price
        /// </summary>
        /// <param name="menu">The menu items in a given search</param>
        /// <param name="min">The mimimum price</param>
        /// <param name="max">The maximum price</param>
        /// <returns>The filtered menu</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
