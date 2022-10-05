using DutyBusinessLayer;
using Microsoft.AspNetCore.Mvc;

namespace TaskScheduler.Controllers
{
    public class DutyController : Controller
    {
        private IDutyService _dutyService;

        public DutyController(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Duty CRUD Menu";
            return View();
        }
    }
}
