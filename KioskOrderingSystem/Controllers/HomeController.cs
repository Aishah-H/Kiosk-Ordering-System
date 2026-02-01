using System.Diagnostics;
using KioskOrderingSystem.Models;
using KioskOrderingSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KioskOrderingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KiosDatabase _kiosDatabase = new();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _kiosDatabase = new KiosDatabase();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Items(string? type) //? means optional
        {
            var items = _kiosDatabase.GetAllItems();

            if (!string.IsNullOrEmpty(type))
            {
                switch (type)
                {
                    case "Sandwhich":
                        return View(_kiosDatabase.GetSandwhiches());

                    case "Beverage":
                        return View(_kiosDatabase.GetBeverages());

                    case "Dessert":
                        return View(_kiosDatabase.GetDesserts());

                    case "All":
                        return View(_kiosDatabase.GetAllItems());

                    default:
                        return View(_kiosDatabase.GetAllItems());

                }
            }

            return View(items);
        }

        [HttpPost]
        public IActionResult Cart(string id)
        {


            return View("Cart", new KioskModel());
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
