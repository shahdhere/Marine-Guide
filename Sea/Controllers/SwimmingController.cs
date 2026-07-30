using Microsoft.AspNetCore.Mvc;

namespace Sea.Controllers
{
    public class SwimmingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
