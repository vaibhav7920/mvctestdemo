using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvctestdemo.Controllers
{
    public class TestActionResulrController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
