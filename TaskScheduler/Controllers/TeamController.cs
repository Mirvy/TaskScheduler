using DutyBusinessLayer;
using Microsoft.AspNetCore.Mvc;

namespace TaskScheduler.Controllers
{
    public class TeamController : Controller
    {
        private ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Team CRUD Menu";
            return View();
        }
    }
}
