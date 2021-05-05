using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proTheme.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace proTheme.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult customer_entry_form()
        {
            return View();
        }
        public IActionResult customer_form()
        {
            return View();
        }
        public IActionResult new_item_group()
        {
            return View();
        }
        public IActionResult items_groups()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult register()
        {
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
