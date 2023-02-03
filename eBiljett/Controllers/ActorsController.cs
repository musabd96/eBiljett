using eBiljett.Data;
using eBiljett.Data.Services;
using eBiljett.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;

namespace eBiljett.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data =await _service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int Id)
        {
            var actorDetails = await _service.GetByIdAsync(Id);

            if (actorDetails == null) return View("NotFund");
            return View(actorDetails);
            
            
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var actorDetails = await _service.GetByIdAsync(Id);

            if (actorDetails == null) return View("NotFund");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id,[Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {

            if (ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(Id, actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
