using eTickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
