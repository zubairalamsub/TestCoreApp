using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestCoreApp.Models;
using TestCoreApp.ViewModels;

namespace TestCoreApp.Controllers
{
    public class TestController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public TestController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // Retrieve employee name and return
        public ViewResult Index()
        {
            var model = _employeeRepository.GetEmployee();
            return View(model);

        }

        public ViewResult EmpDeatil()
        {
            EmpDetailsViewModel empDetailsViewModel = new EmpDetailsViewModel()

            {
                Employee=_employeeRepository.GetEmployee(1),
                PageTitle= "Employee Page"
            };

            
            return View(empDetailsViewModel);

        }

    }
}