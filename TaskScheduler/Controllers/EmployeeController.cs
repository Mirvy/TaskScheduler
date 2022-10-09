using DutyBusinessLayer;
using DutyBusinessLayer.ViewModels;
using DutyModels;
using Microsoft.AspNetCore.Mvc;

namespace TaskScheduler.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        private IDutyService _dutyService;
        private ITeamService _teamService;

        public EmployeeController(IEmployeeService employeeService, IDutyService dutyService, ITeamService tenantService)
        {
            _employeeService = employeeService;
            _dutyService = dutyService;
            _teamService = tenantService;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _employeeService.GetEmployees();
            ViewBag.Title = "Employee CRUD Menu";
            return View(employees);
        }

        public async Task<IActionResult> Create()
        {
            return View("EmployeeForm", ViewModelFactory.EmployeeCreate(new Employee(), await _dutyService.GetDuties(), await _teamService.GetTeams()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee e)
        {
            if (ModelState.IsValid)
            {
                e.Team = default;
                if(e.TeamId == 0)
                {
                    e.TeamId = null;
                }
                await _employeeService.Add(e);
                return RedirectToAction(nameof(Index));
            }
            return View("EmployeeForm", ViewModelFactory.EmployeeCreate(e, await _dutyService.GetDuties(), await _teamService.GetTeams()));
        }

        public async Task<IActionResult> Details(int id)
        {
            Employee e = await _employeeService.GetById(id);
            if (e != null)
            {
                List<Duty> duties = await _dutyService.GetDuties();
                List<Team> teams = await _teamService.GetTeams();
                EmployeeViewModel model = ViewModelFactory.EmployeeDetails(e, duties, teams);
                return View("EmployeeForm", model);
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Employee e = await _employeeService.GetById(id);
            if (e != null)
            {
                List<Duty> duties = await _dutyService.GetDuties();
                List<Team> teams = await _teamService.GetTeams();
                EmployeeViewModel model = ViewModelFactory.EmployeeEdit(e, duties, teams);
                return View("EmployeeForm", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee e)
        {
            if (ModelState.IsValid)
            {
                e.Team = default;
                if (e.TeamId == 0)
                {
                    e.TeamId = null;
                }
                await _employeeService.Update(e);
                return RedirectToAction(nameof(Index));
            }
            return View("DutyForm", ViewModelFactory.EmployeeEdit(e, await _dutyService.GetDuties(), await _teamService.GetTeams()));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Employee e = await _employeeService.GetById(id);
            if (e != null)
            {
                List<Duty> duties = await _dutyService.GetDuties();
                List<Team> teams = await _teamService.GetTeams();
                EmployeeViewModel model = ViewModelFactory.EmployeeDelete(e, duties, teams);
                return View("EmployeeForm", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Employee e)
        {
            await _employeeService.Remove(e);
            return RedirectToAction(nameof(Index));
        }
    }
}
