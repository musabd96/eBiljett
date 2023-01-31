using eBiljett.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBiljett.Controllers
{
    public class MoviesControllers : Controller
    {
        private readonly AppDbContext _context;

        public MoviesControllers(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
