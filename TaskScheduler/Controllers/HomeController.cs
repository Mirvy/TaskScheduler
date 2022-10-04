using DutyBusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskScheduler.Controllers
{
    public class HomeController : Controller
    {
        private IDutyService _dutyService;
        private ITeamService _teamService;
        private IEmployeeService _employeeService;
        private IProjectService _projectService;

        public HomeController(IDutyService dutyService, ITeamService teamService, IEmployeeService employeeService, IProjectService projectService)
        {
            _dutyService = dutyService;
            _teamService = teamService;
            _employeeService = employeeService;
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
