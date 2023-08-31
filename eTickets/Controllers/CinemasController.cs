using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var ListOfCinemas= await _context.Cinemas.ToListAsync();
            return View(ListOfCinemas);
        }
    }
}
