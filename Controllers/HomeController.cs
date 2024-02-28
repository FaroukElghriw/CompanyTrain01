using Microsoft.AspNetCore.Mvc;

namespace CompanyTrain01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUS()
        {
            return View();
        }
        public IActionResult ContactUS() 
        {
            return View();
        }

       
    }
}
