using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var ListOfActors = await  _context.Actors.ToListAsync();
            return View(ListOfActors);
        }
    }
}
