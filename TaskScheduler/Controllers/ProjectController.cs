using DutyBusinessLayer;
using DutyBusinessLayer.ViewModels;
using DutyModels;
using Microsoft.AspNetCore.Mvc;

namespace TaskScheduler.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectService _projectService;
        private ITeamService _teamService;
        private IDutyService _dutyService;

        public ProjectController(IProjectService projectService, ITeamService teamService, IDutyService dutyService)
        {
            _projectService = projectService;
            _teamService = teamService;
            _dutyService = dutyService;
        }

        public async Task<IActionResult> Index()
        {
            List<Project> projects = await _projectService.GetProjects();
            ViewBag.Title = "Project CRUD Menu";
            return View(projects);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Title = "Project Create";
            List<Team> t = await _teamService.GetTeams();
            List<Duty> d = await _dutyService.GetDuties();
            ProjectViewModel model = ViewModelFactory.ProjectCreate(new Project(), t, d);
            return View("ProjectForm", model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project p)
        {
            if (ModelState.IsValid)
            {
                if (p.AssignedId == 0)
                {
                    p.AssignedId = null;
                }
                await _projectService.Add(p);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Title = "Project Create";
            return View("ProjectForm",ViewModelFactory.ProjectCreate(p,await _teamService.GetTeams(),await _dutyService.GetDuties()));
        }

        public async Task<IActionResult> Details(int id)
        {
            ViewBag.Title = "Project Details";
            Project? p = await _projectService.GetById(id);
            if (p != null)
            {
                List<Team> t = await _teamService.GetTeams();
                List<Duty> d = await _dutyService.GetDuties();
                ProjectViewModel model = ViewModelFactory.ProjectDetails(p, t, d);
                return View("ProjectForm", model);
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Title = "Project Edit";
            Project? p = await _projectService.GetById(id);
            if (p != null)
            {
                List<Team> t = await _teamService.GetTeams();
                List<Duty> d = await _dutyService.GetDuties();
                ProjectViewModel model = ViewModelFactory.ProjectEdit(p, t, d);
                return View("ProjectForm", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Project p)
        {
            if (ModelState.IsValid)
            {
                p.Assigned = default;
                if (p.AssignedId == 0)
                {
                    p.AssignedId = null;
                }
                await _projectService.Update(p);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Title = "Project Edit";
            return View("ProjectForm", ViewModelFactory.ProjectEdit(p, await _teamService.GetTeams(), await _dutyService.GetDuties()));
        }

        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Title = "Project Delete";
            Project p = await _projectService.GetById(id);
            if(p != null)
            {
                List<Duty> d = await _dutyService.GetDuties();
                List<Team> t = await _teamService.GetTeams();
                ProjectViewModel model = ViewModelFactory.ProjectDelete(p, t, d);
                return View("ProjectForm", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Project p)
        {
            await _projectService.Remove(p);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> AddDuty(int projectId, int dutyId)
        {
            Project p = await _projectService.GetById(projectId);
            Duty d = await _dutyService.GetById(dutyId);
            p.Duties.Add(d);
            await _projectService.Update(p);
            return RedirectToAction(nameof(Edit), new { id = projectId});
        }

        [HttpPost]
        public async Task<IActionResult> RemoveDuty(int projectId, int dutyId)
        {
            Project p = await _projectService.GetById(projectId);
            Duty d = await _dutyService.GetById(dutyId);
            p.Duties.Remove(d);
            await _projectService.Update(p);
            return RedirectToAction(nameof(Edit), new { id = projectId });
        }

    }
}
