using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestCoreApp.Controllers
{
    public class DepartmetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}