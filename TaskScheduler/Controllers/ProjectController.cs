using DutyBusinessLayer;
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

        public IActionResult Index()
        {
            ViewBag.Title = "Project CRUD Menu";
            return View();
        }
    }
}
