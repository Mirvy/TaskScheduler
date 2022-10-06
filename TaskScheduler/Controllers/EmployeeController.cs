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

        public async Task<IActionResult> Index()
        {
            var employees = await _employeeService.GetEmployees();
            ViewBag.Title = "Employee CRUD Menu";
            return View(employees);
        }
    }
}
