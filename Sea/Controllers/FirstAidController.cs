using Microsoft.AspNetCore.Mvc;
using Sea.Models;


namespace Sea.Controllers
{
    public class FirstAidController : Controller
    {
        private readonly AppDbContext _context;

        public FirstAidController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var firstAid = _context.FirstAids.ToList();
            return View(firstAid);
        }
    }
}
