/*

* Author: Kendall Price

* Class name: MenuTests.cs

* Purpose: Tests that menu collections contain one of expected items and search and filters work as expected

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;
using Xunit;
using System.Linq;
namespace CowboyCafe.DataTests.MenuTests
{
    public class MenuTests
    {

        [Fact]
        public void AllShouldReturnAllExpectedItems()
        {
            var all = new List<IOrderItem>(Menu.All);
            all.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                all,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cpc) => { Assert.IsType<CowpokeChili>(cpc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (cbc) => { Assert.IsType<CowboyCoffee>(cbc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        [Fact]
        public void EntreeShouldReturnAllExpectedEntrees()
        {
            var entrees = new List<IOrderItem>(Menu.Entree);
            entrees.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cpc) => { Assert.IsType<CowpokeChili>(cpc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        [Fact]
        public void SideShouldReturnAllExpectedSides()
        {
            var sides = new List<IOrderItem>(Menu.Side);
            sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        [Fact]
        public void DrinkShouldReturnAllExpectedDrinks()
        {
            var sides = new List<IOrderItem>(Menu.Drink);
            sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                sides,
                (cbc) => { Assert.IsType<CowboyCoffee>(cbc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        [Theory]
        [InlineData("a")]
        [InlineData("cow")]
        [InlineData("Burger")]
        [InlineData(" ")]
        [InlineData("alpha")]
        [InlineData("e c")]
        [InlineData("tea")]
        [InlineData("wa")]
        [InlineData("")]
        public void SearchTermsShouldFilter(string terms)
        {
            IEnumerable<IOrderItem> start = Menu.All;
            IEnumerable<IOrderItem> menu = Menu.Search(start, terms);
            foreach(IOrderItem item in menu)
            {
                Assert.Contains(terms.ToLower(), item.ToString().ToLower());
            }
        }

        [Fact]
        public void NullSearchTermsShouldReturnAll()
        {
            IEnumerable<IOrderItem> start = Menu.All;
            IEnumerable<IOrderItem> menu = Menu.Search(start, null);
            Assert.Equal(menu.Count(), start.Count());
            Assert.Equal(menu, start);

            
        }

        [Fact]
        public void EntreeCategoryShouldFilterOtherCategoriesOut()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            var category = new List<string>();
            category.Add("Entree");
            menu = Menu.FilterByCategory(menu, category);
            foreach(IOrderItem item in menu)
            {
                Assert.IsAssignableFrom<Entree>(item);
            }
        }

        [Fact]
        public void SideCategoryShouldFilterOtherCategoriesOut()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            var category = new List<string>();
            category.Add("Side");
            menu = Menu.FilterByCategory(menu, category);
            foreach (IOrderItem item in menu)
            {
                Assert.IsAssignableFrom<Side>(item);
            }
        }

        [Fact]
        public void DrinkCategoryShouldFilterOtherCategoriesOut()
        {
            IEnumerable<IOrderItem> menu = Menu.All;
            var category = new List<string>();
            category.Add("Drink");
            menu = Menu.FilterByCategory(menu, category);
            foreach (IOrderItem item in menu)
            {
                Assert.IsAssignableFrom<Drink>(item);
            }
        }

        [Fact]
        public void EmptyCategoryShouldNotFilter()
        {
            IEnumerable<IOrderItem> start = Menu.All;
            var category = new List<string>();
            IEnumerable<IOrderItem> menu = Menu.FilterByCategory(start, category);
            Assert.Equal(menu.Count(), start.Count());
            Assert.Equal(menu, start);
        }

        [Fact]
        public void NullCategoryShouldNotFilter()
        {
            IEnumerable<IOrderItem> start = Menu.All;
            IEnumerable<IOrderItem> menu = Menu.FilterByCategory(start, null);
            Assert.Equal(menu.Count(), start.Count());
            Assert.Equal(menu, start);
        }

        [Fact]
        public void NullPricesShouldNotFilter()
        {
            IEnumerable<IOrderItem> start = Menu.All;
            IEnumerable<IOrderItem> menu = Menu.FilterByPrice(start, null, null);
            Assert.Equal(menu.Count(), start.Count());
            Assert.Equal(menu, start);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(0)]
        [InlineData(5.99)]
        [InlineData(1.01)]
        [InlineData(0.12)]
        [InlineData(3.79)]
        public void NullMinPriceShouldOnlyFilterMax(double? max)
        {
            IEnumerable<IOrderItem> menu = Menu.FilterByPrice(Menu.All, null, max);
            foreach(IOrderItem item in menu)
            {
                Assert.True(item.Price <= max);
            }
        }

        [Theory]
        [InlineData(10)]
        [InlineData(0)]
        [InlineData(5.99)]
        [InlineData(1.01)]
        [InlineData(0.12)]
        [InlineData(3.79)]
        public void NullMaxPriceShouldOnlyFilterMin(double? min)
        {
            IEnumerable<IOrderItem> menu = Menu.FilterByPrice(Menu.All, min, null);
            foreach (IOrderItem item in menu)
            {
                Assert.True(item.Price >= min);
            }
        }

        [Theory]
        [InlineData(10, 10)]
        [InlineData(0, 0)]
        [InlineData(10, 0)]
        [InlineData(0, 10)]
        [InlineData(2, 5.99)]
        [InlineData(1.01, 7.99)]
        [InlineData(0.12, 0.12)]
        [InlineData(3.79, 3.8)]
        public void MinAndMaxPriceShouldFilter(double? min, double? max)
        {
            IEnumerable<IOrderItem> menu = Menu.FilterByPrice(Menu.All, min, max);
            foreach (IOrderItem item in menu)
            {
                Assert.True(item.Price >= min && item.Price <= max);
            }
        }

        [Fact]
        public void NullCaloriesShouldNotFilter()
        {
            IEnumerable<IOrderItem> start = Menu.All;
            IEnumerable<IOrderItem> menu = Menu.FilterByCalories(start, null, null);
            Assert.Equal(menu.Count(), start.Count());
            Assert.Equal(menu, start);
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(0)]
        [InlineData(599)]
        [InlineData(101)]
        [InlineData(12)]
        [InlineData(379)]
        public void NullMinCalorieShouldOnlyFilterMax(int? max)
        {
            IEnumerable<IOrderItem> menu = Menu.FilterByCalories(Menu.All, null, max);
            foreach (IOrderItem item in menu)
            {
                Assert.True(item.Calories <= max);
            }
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(0)]
        [InlineData(599)]
        [InlineData(101)]
        [InlineData(12)]
        [InlineData(379)]
        public void NullMaxCalorieShouldOnlyFilterMin(int? min)
        {
            IEnumerable<IOrderItem> menu = Menu.FilterByCalories(Menu.All, min, null);
            foreach (IOrderItem item in menu)
            {
                Assert.True(item.Calories >= min);
            }
        }

        [Theory]
        [InlineData(1000, 1000)]
        [InlineData(0, 0)]
        [InlineData(1000, 0)]
        [InlineData(0, 1000)]
        [InlineData(2, 599)]
        [InlineData(101, 799)]
        [InlineData(190, 190)]
        [InlineData(379, 380)]
        public void MinAndMaxCalorieShouldFilter(int? min, int? max)
        {
            IEnumerable<IOrderItem> menu = Menu.FilterByCalories(Menu.All, min, max);
            foreach (IOrderItem item in menu)
            {
                Assert.True(item.Calories >= min && item.Calories <= max);
            }
        }
    }
}
