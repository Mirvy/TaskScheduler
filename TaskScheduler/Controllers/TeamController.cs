using DutyBusinessLayer;
using DutyModels;
using DutyBusinessLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace TaskScheduler.Controllers
{
    [Authorize]
    public class TeamController : Controller
    {
        private ITeamService _teamService;
        private IEmployeeService _employeeService;
        private IProjectService _projectService;

        public TeamController(ITeamService teamService, IEmployeeService employeeService, IProjectService projectService)
        {
            _teamService = teamService;
            _employeeService = employeeService;
            _projectService = projectService;
        }

        public async Task<IActionResult> Index()
        {
            List<Team> teams = await _teamService.GetTeams();
            ViewBag.Title = "Team CRUD Menu";
            return View(teams);
        }

        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Team Details";
            Team t = await _teamService.GetById(id);
            if(t != null)
            {
                List<Project> p = await _projectService.GetProjects();
                List<Employee> e = await _employeeService.GetEmployees();
                TeamViewModel model = ViewModelFactory.TeamDetails(t, e, p);
                return View("TeamForm", model);
            }
            return NotFound();
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Team Create";
            List<Project> p = await _projectService.GetProjects();
            List<Employee> e = await _employeeService.GetEmployees();
            TeamViewModel model = ViewModelFactory.TeamCreate(new Team(), e, p);
            return View("TeamForm", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Team t)
        {
            if (ModelState.IsValid)
            {
                await _teamService.Add(t);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Title = "Team Create";
            return View("TeamForm", ViewModelFactory.TeamCreate(t, await _employeeService.GetEmployees(), await _projectService.GetProjects()));
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "Team Edit";
            Team t = await _teamService.GetById(id);
            if(t != null)
            {
                List<Project> p = await _projectService.GetProjects();
                List<Employee> e = await _employeeService.GetEmployees();
                TeamViewModel model = ViewModelFactory.TeamEdit(t, e, p);
                return View("TeamForm", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Team t)
        {
            if (ModelState.IsValid)
            {
                await _teamService.Update(t);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Title = "Team Edit";
            return View("TeamForm", ViewModelFactory.TeamEdit(t, await _employeeService.GetEmployees(), await _projectService.GetProjects()));
        }

        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Title = "Team Delete";
            Team t = await _teamService.GetById(id);
            if (t != null)
            {
                List<Project> p = await _projectService.GetProjects();
                List<Employee> e = await _employeeService.GetEmployees();
                TeamViewModel model = ViewModelFactory.TeamDelete(t, e, p);
                return View("TeamForm", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Team t)
        {
            await _teamService.Remove(t);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(int teamId, int employeeId)
        {
            Team t = await _teamService.GetById(teamId);
            Employee e = await _employeeService.GetById(employeeId);
            t.Employees.Add(e);
            e.Team = t;
            await _teamService.Update(t);
            await _employeeService.Update(e);
            return RedirectToAction(nameof(Edit), new { id = teamId });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveEmployee(int teamId, int employeeId)
        {
            Team t = await _teamService.GetById(teamId);
            Employee e = await _employeeService.GetById(employeeId);
            t.Employees.Remove(e);
            e.TeamId = null;
            await _teamService.Update(t);
            await _employeeService.Update(e);
            return RedirectToAction(nameof(Edit), new { id = teamId });
        }
    }
}
