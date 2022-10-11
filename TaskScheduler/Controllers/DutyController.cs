using DutyBusinessLayer;
using Microsoft.AspNetCore.Mvc;
using DutyModels;
using DutyBusinessLayer.ViewModels;
using System.Net.Http.Headers;

namespace TaskScheduler.Controllers
{
    public class DutyController : Controller
    {
        private IDutyService _dutyService;
        private IEmployeeService _employeeService;
        private IProjectService _projectService;

        public DutyController(IDutyService dutyService,IEmployeeService employeeService, IProjectService projectService)
        {
            _dutyService = dutyService;
            _employeeService = employeeService;
            _projectService = projectService;
        }

        public async Task<IActionResult> Index()
        {
            List<Duty> duties = await _dutyService.GetDuties();
            ViewBag.Title = "Duty CRUD Menu";
            return View(duties);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Duty Create";
            return View("DutyForm", ViewModelFactory.DutyCreate(new Duty(), await _employeeService.GetEmployees(),await _projectService.GetProjects()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Duty d)
        {
            if (ModelState.IsValid)
            {
                d.Assigned = default;
                if (d.AssignedId == 0)
                {
                    d.AssignedId = null;
                }
                d.Project = default;
                if (d.ProjectId == 0)
                {
                    d.ProjectId = null;
                }
                await _dutyService.Add(d);
                return RedirectToAction(nameof(Index));
            }
            return View("DutyForm", ViewModelFactory.DutyCreate(d, await _employeeService.GetEmployees(),await _projectService.GetProjects()));
        }

        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Duty Details";
            Duty? d = await _dutyService.GetById(id);
            if(d != null)
            {
                DutyViewModel model = ViewModelFactory.DutyDetails(d);
                return View("DutyForm", model);
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "Duty Edit";
            Duty? d = await _dutyService.GetById(id);
            if (d != null)
            {
                List<Employee> e = await _employeeService.GetEmployees();
                List<Project> p = await _projectService.GetProjects();
                DutyViewModel model = ViewModelFactory.DutyEdit(d, e, p);
                return View("DutyForm", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Duty d)
        {
            if (ModelState.IsValid)
            {
                d.Assigned = default;
                if (d.AssignedId == 0)
                {
                    d.AssignedId = null;
                }
                d.Project = default;
                if (d.ProjectId == 0)
                {
                    d.ProjectId = null;
                }
                await _dutyService.Update(d);
                return RedirectToAction(nameof(Index));
            }
            return View("DutyForm", ViewModelFactory.DutyEdit(d,await _employeeService.GetEmployees(),await _projectService.GetProjects()));
        }


        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Title = "Duty Delete";
            Duty? d = await _dutyService.GetById(id);
            if (d != null)
            {
                return View("DutyForm", ViewModelFactory.DutyDelete(d));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Duty d)
        {
            await _dutyService.Remove(d);
            return RedirectToAction(nameof(Index));
        }
    }
}
