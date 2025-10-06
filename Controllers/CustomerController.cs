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
            //test
            IEnumerable<Customer> allCustomer = _db.tb_Customers;

            return View(allCustomer);
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Customer obj)
        {
            Debug.WriteLine("Cutomer Fullname " + obj.Cus_Fullname);

            _db.tb_Customers.Add(obj);
            _db.SaveChanges();

            return View();
        }
    }
}
