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

        public DutyController(IDutyService dutyService,IEmployeeService employeeService)
        {
            _dutyService = dutyService;
            _employeeService = employeeService;
        }

        public async Task<IActionResult> Index()
        {
            List<Duty> duties = await _dutyService.GetDuties();
            ViewBag.Title = "Duty CRUD Menu";
            return View(duties);
        }

        public async Task<IActionResult> Create()
        {
            return View("DutyForm", ViewModelFactory.DutyCreate(new Duty(), await _employeeService.GetEmployees()));
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
                await _dutyService.Add(d);
                return RedirectToAction(nameof(Index));
            }
            return View("DutyForm", ViewModelFactory.DutyCreate(d, await _employeeService.GetEmployees()));
        }

        public async Task<IActionResult> Details(int id)
        {
            Duty? d = await _dutyService.GetById(id);
            DutyViewModel model = ViewModelFactory.DutyDetails(d);
            return View("DutyForm",model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Duty? d = await _dutyService.GetById(id);
            if (d != null)
            {
                List<Employee> e = await _employeeService.GetEmployees();
                DutyViewModel model = ViewModelFactory.DutyEdit(d, e);
                return View("DutyForm", model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Duty d)
        {
            Console.WriteLine(d.ToString());
            if (ModelState.IsValid)
            {
                d.Assigned = default;
                if (d.AssignedId == 0)
                {
                    d.AssignedId = null;
                }
                await _dutyService.Update(d);
                return RedirectToAction(nameof(Index));
            }
            return View("DutyForm", ViewModelFactory.DutyEdit(d,await _employeeService.GetEmployees()));
        }


        public async Task<IActionResult> Delete(int id)
        {
            Duty? d = await _dutyService.GetById(id);
            return View("DutyForm",ViewModelFactory.DutyDelete(d));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Duty d)
        {
            await _dutyService.Remove(d);
            return RedirectToAction(nameof(Index));
        }
    }
}
