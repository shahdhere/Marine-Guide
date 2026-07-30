using Microsoft.AspNetCore.Mvc;

namespace Sea.Controllers
{
    public class FishingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
