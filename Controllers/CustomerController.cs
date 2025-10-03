using food_asp.Data;
using Microsoft.AspNetCore.Mvc;

namespace food_asp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CustomerController(ApplicationDBContext db)
        {
            _db = db;
        }
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
