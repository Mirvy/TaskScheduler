using DutyBusinessLayer;
using Microsoft.AspNetCore.Mvc;
using DutyModels;

namespace TaskScheduler.Controllers
{
    public class DutyController : Controller
    {
        private IDutyService _dutyService;

        public DutyController(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        public async Task<IActionResult> Index()
        {
            List<Duty> duties = await _dutyService.GetDuties();
            ViewBag.Title = "Duty CRUD Menu";
            return View(duties);
        }

        public async Task<IActionResult> Details(int id)
        {
            Duty? d = await _dutyService.GetById(id);
            return View("DutyForm",d ?? new Duty());
        }

        public async Task<IActionResult> Edit(int id=1)
        {
            Duty? d = await _dutyService.GetById(id);
            return View("DutyForm");
        }

        public async Task<IActionResult> Delete(int id=1)
        {
            Duty? d = await _dutyService.GetById(id);
            return View("DutyForm");
        }
    }
}
