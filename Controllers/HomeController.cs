using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coreweb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coreweb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Employee.GetEmployees());
        }
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Create()
        //{
        //    return View();
        //}
    }
}