using Microsoft.AspNetCore.Mvc;

namespace food_asp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
