using DutyBusinessLayer;
using DutyModels;
using Microsoft.AspNetCore.Mvc;

namespace TaskScheduler.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public async Task<IActionResult> Index()
        {
            List<Project> projects = await _projectService.GetProjects();
            ViewBag.Title = "Project CRUD Menu";
            return View(projects);
        }
    }
}
