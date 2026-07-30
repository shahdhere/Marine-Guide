using Microsoft.AspNetCore.Mvc;

namespace Sea.Controllers
{
    public class MarineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
