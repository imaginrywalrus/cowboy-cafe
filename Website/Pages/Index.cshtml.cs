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
        public IEnumerable<IOrderItem> menu { get; protected set; }

        /// <summary>
        /// Gets and sets teh Category filters
        /// </summary>
        public string[] category { get; set; }

        /// <summary>
        /// Gets and sets the search terms
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Gets and sets the calories minimum amount
        /// </summary>
        public int? caloriesMin { get; set; }

        /// <summary>
        /// Gets and sets the calories maximum amount
        /// </summary>
        public int? caloriesMax { get; set; }

        /// <summary>
        /// Gets and sets the prices minimum amount
        /// </summary>
        public double? priceMin { get; set; }

        /// <summary>
        /// Gets and sets the prices maximum amount
        /// </summary>
        public double? priceMax { get; set; }

        /// <summary>
        /// Does the response initialization for incoming GET requests
        /// </summary>
        /// <param name="caloriesMin">Min calories for searches</param>
        /// <param name="caloriesMax">Max calories for searches</param>
        /// <param name="priceMin">Min price for searches</param>
        /// <param name="priceMax">Max price for searches</param>
        public void OnGet(int? caloriesMin, int? caloriesMax, double? priceMin, double? priceMax)
        {
            this.caloriesMin = caloriesMin;
            this.caloriesMax = caloriesMax;
            this.priceMax = priceMax;
            this.priceMin = priceMin;
            SearchTerms = Request.Query["SearchTerms"];
            category = Request.Query["category"];
            menu = Menu.Search(menu, SearchTerms);
            menu = Menu.FilterByCategory(menu, category);
            menu = Menu.FilterByCalories(menu, caloriesMin, caloriesMax);
            menu = Menu.FilterByPrice(menu, priceMin, priceMax);
        }
    }
}
