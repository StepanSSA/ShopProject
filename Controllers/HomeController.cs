using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopProject.Data;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var catNSubcat = new Dictionary<string, List<string>>();
            var category = _context.Categories.ToList();
            var subcategory = _context.Subcategories.ToList();

            for (int i = 0; i < category.Count; i++)
            {
                var cat = category[i].name;
                var subcat = subcategory
                    .Where(x => x.idCategory == category[i].id)
                    .Select(x => x.name)
                    .ToList();
                if(subcat != null && subcat.Count > 0)
                    catNSubcat.Add(cat, subcat);
            }
            ViewBag.Category = catNSubcat;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
