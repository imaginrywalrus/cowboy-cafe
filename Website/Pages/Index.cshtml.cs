using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The menu to display on the website
        /// </summary>
        public IEnumerable<IOrderItem> Menus { get; protected set; }

        /// <summary>
        /// Gets and sets teh Category filters
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] category { get; set; }

        /// <summary>
        /// Gets and sets the search terms
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Gets and sets the calories minimum amount
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? caloriesMin { get; set; }

        /// <summary>
        /// Gets and sets the calories maximum amount
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? caloriesMax { get; set; }

        /// <summary>
        /// Gets and sets the prices minimum amount
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? priceMin { get; set; }

        /// <summary>
        /// Gets and sets the prices maximum amount
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? priceMax { get; set; }

        /// <summary>
        /// Does the response initialization for incoming GET requests
        /// </summary>
        public void OnGet()
        {
            Menus = Menu.All;
            // Filter search terms
            if (SearchTerms != null)
            {
                Menus = Menus.Where(menu => menu.ToString() != null && menu.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase));
            }

            // Filter Genre
            if (category != null && category.Length != 0)
            {
                Menus = Menus.Where(menu => menu.Category != null && category.Contains(menu.Category));
            }

            // Filter IMDB rating
            if (priceMax != null && priceMin != null)
            {
                Menus = Menus.Where(menu => menu.Price >= priceMin && menu.Price <= priceMax);
            }

            // Filter Rotten Tomatoes rating
            if (caloriesMin != null && caloriesMax != null)
            {
                Menus = Menus.Where(menu => menu.Calories >= caloriesMin && menu.Calories <= caloriesMax);
            }
        }
    }
}
