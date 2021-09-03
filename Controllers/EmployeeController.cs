using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coreweb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coreweb.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            return View(employeeRepository.GetEmployees());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee e)
        {
            employeeRepository.AddEmployee(e);
            return View();
        }
    }
}