using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
