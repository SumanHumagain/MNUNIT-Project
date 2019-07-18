using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Models;

namespace UnitTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetEmployeeName(int empId)
        {
            string name;
            if (empId == 1)
            {
                name = "Suman";
            }
            else if (empId == 2)
            {
                name = "Nirajan";
            }
            else
            {
                name = "Error";
            }
            return name;
        }
    }
}
