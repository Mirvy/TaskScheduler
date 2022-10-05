using DutyBusinessLayer;
using Microsoft.AspNetCore.Mvc;

namespace TaskScheduler.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Employee CRUD Menu";
            return View();
        }
    }
}
