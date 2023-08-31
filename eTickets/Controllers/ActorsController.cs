using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
