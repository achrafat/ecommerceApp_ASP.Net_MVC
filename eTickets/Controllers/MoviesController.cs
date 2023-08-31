using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public async  Task<IActionResult> Index()
        {
            var ListOfMovies= await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.MovieName).ThenByDescending(n=>n.EndDate).ToListAsync();
            return View(ListOfMovies);
        }
    }
}
