using food_asp.Data;
using food_asp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            //select data
            /*IEnumerable<Customer> allCustomer = _db.tb_Customers;

            return View(allCustomer);*/
            return View();
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Customer obj_register)
        {
            Debug.WriteLine("Cutomer Fullname " + obj_register.Cus_Fullname);
            if (ModelState.IsValid)
            {
                _db.tb_Customers.Add(obj_register);
                _db.SaveChanges();

                return RedirectToAction("Customerlogin");
            }
            return View(obj_register);

        }

        //post login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Customerlogin(Customer obj_login) 
        {
            Debug.WriteLine("Login Username: " + obj_login.Cus_Username);
            return View();
        }
    }
}
