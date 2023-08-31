using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
