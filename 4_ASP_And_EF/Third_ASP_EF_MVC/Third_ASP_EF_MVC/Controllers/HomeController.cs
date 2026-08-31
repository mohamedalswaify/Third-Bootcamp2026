using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Third_ASP_EF_MVC.Models;

namespace Third_ASP_EF_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Mohamed()
        {
            return Content("Hell0, Mohamed!");
        }

        public IList<string> ListEmployee()
        {
            IList<string> names = new List<string>();

            names.Add("Mohamed");
            names.Add("Ali");
            names.Add("Sayed");
            names.Add("Ahmed");
            names.Add("Sara");
            return names;


        }



        public IActionResult Index()
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
