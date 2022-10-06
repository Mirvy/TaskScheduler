using DutyBusinessLayer;
using DutyModels;
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

        public async Task<IActionResult> Index()
        {
            List<Team> teams = await _teamService.GetTeams();
            ViewBag.Title = "Team CRUD Menu";
            return View(teams);
        }
    }
}
