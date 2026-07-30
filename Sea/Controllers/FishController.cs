using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sea.Models;

namespace Sea.Controllers
{
    public class FishController : Controller
    {
        private readonly AppDbContext _context;
        public FishController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var fish = _context.Fish.Include(f => f.Category).ToList();
            return View(fish);
        }
        public IActionResult Details(int id)
        {
            var fish = _context.Fish
                .Include(f => f.Category)
                .FirstOrDefault(f => f.Id == id);

            return View(fish);
        }
    }
}

