using Microsoft.AspNetCore.Mvc;

namespace EpitaExpenseTracker.Controllers
{
    public class CascadingDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
