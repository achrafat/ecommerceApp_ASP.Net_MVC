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
        public IActionResult Edit(int id)
        {
           var actorDetails=_service.GetById(id);
            if(actorDetails == null) { View("Not Found"); }
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ActorId", "ProfilePictureURL,FullName,Bio")] Actor newActor)
        {
            if (!ModelState.IsValid)
            {
                return View(newActor);
            }
            _service.Upadate(id,newActor);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var actorDetails = _service.GetById(id);
            if (actorDetails == null) { View("Not Found"); }
            return View(actorDetails);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = _service.GetById(id);
            if (actorDetails == null) { View("Not Found"); }
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
