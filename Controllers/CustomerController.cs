using Microsoft.AspNetCore.Mvc;

namespace food_asp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register() 
        { 
            return View();
        }

        public IActionResult Customerlogin() 
        {
            return View();
        }
    }
}
