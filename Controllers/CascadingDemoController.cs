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

        public JsonResult GetStates(string country)
        {
            if (CountryStateData.TryGetValue(country, out List<string> states))
            {
                return Json(states);
            }
            return Json(new List<string>());
        }
    }
}
