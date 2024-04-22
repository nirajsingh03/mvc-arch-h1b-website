using H1B_Viz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace H1B_Viz.Controllers
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

        public IActionResult Requirements()
        {
            return View();
        }

        public IActionResult LCApp()
        {
            return View();
        }

        public IActionResult Visualization()
        {
            return View();
        }

        public IActionResult NewDataForm()
        {
            return View();
        }

        public IActionResult InquiryForm()
        {
            return View();
        }


        public IActionResult AboutUs()
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
