using Microsoft.AspNetCore.Mvc;

namespace Yosanai.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = ".NET Core Web/REST App Base";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "https://github.com/perusworld/dotnetcore-base";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
