using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvctestdemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mvctestdemo.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public PartialViewResult Parent()
        {
            return PartialView("_Address");
        }

        public RedirectResult ErrorPage()
        {
            return Redirect("RedirectHere");
        }

        public ActionResult RedirectHere()
        {
            return View();
        }

        public ActionResult Test()
        {
            return RedirectToAction("GetDetails", "Employee");

        }

        public JsonResult jsonResultview()
        {

            // method 1 to add details to list
            List<Customer> lst = new List<Customer>();
            Customer customer1 = new Customer();
            customer1.custid = 1;
            customer1.name = "Vaibhav";
            customer1.age = 22;

            Customer customer2 = new Customer();
            customer2.custid = 2;
            customer2.name = "ABC";
            customer2.age = 22;

            lst.Add(customer1);
            lst.Add(customer2);


            // method2

            var customers = new List<Customer>
            {
                new Customer{custid=3, name="tt", age=22},
                new Customer{custid=4, name="PQR", age=24}
            };

            return Json(customers);
        }




        public FileResult file()
        {
            var physicalfilepath = "C:/Users/vaipar01/OneDrive - Robert Half/Desktop/hello.txt";
            var filebytes = System.IO.File.ReadAllBytes(physicalfilepath);
            return File(filebytes, "text/plain", "hello.txt");
                
                }


        public ContentResult Contact()
        {
            return Content("welcome all");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
