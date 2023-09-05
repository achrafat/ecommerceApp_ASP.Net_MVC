using eTickets.Data;
using eTickets.Data.services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService actorsService)
        {
            _service = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            var ListOfActors = await _service.GetAll();
            return View(ListOfActors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Actor newActor) {
            if(!ModelState.IsValid){
                return View(newActor);
                        }
            _service.Add(newActor);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Details(int id ) {
            var actorDetails=_service.GetById(id);
            if(actorDetails == null) {
                return View("Empty");
            }
            return View(actorDetails);
            
        }
    }
}
