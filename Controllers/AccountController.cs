using Microsoft.AspNetCore.Mvc;

namespace CompanyTrain01.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Regsiter()
        {
            return View();
        }

    }
}
