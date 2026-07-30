using Microsoft.AspNetCore.Mvc;

namespace Sea.Controllers
{
    public class BoatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
