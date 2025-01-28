using Microsoft.AspNetCore.Mvc;

namespace EpitaExpenseTracker.Controllers
{
    public class CascadingDemoController : Controller
    {


        private static readonly Dictionary<string, List<string>> CountryStateData = new()
    {
        { "USA", new List<string> { "California", "Texas", "Florida" } },
        { "Canada", new List<string> { "Ontario", "Quebec", "British Columbia" } },
        { "India", new List<string> { "Maharashtra", "Karnataka", "Delhi" } }
    };



        public IActionResult Index()
        {
            ViewBag.Countries = CountryStateData.Keys;
            return View();
        }
    }
}
