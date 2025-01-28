using EpitaExpenseTracker.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace EpitaExpenseTracker.Controllers
{
    public class MovieController : Controller
    {


        private readonly ILogger<MovieController> _logger;
        private readonly ExpenseDbContext _context;

        public MovieController(ILogger<MovieController> logger, ExpenseDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Index has been called");

            var movies = _context.Movies.ToList();

            return View(movies);
           
        }
        public IActionResult CreateEditMovie(int? Id)
        {
            if (Id is not null)
            {
                var item = _context.Movies.Find(Id);
                return View(item);
            }
            return View();
        }

        public IActionResult CreateEditMovieForm(Movie model)
        {
            if (model.Id == 0)
            {
               
                _context.Movies.Add(model);

            }
            else
            {
               
                _context.Movies.Update(model);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
           
            var item = _context.Movies.Find(id);

            if (item is not null)
            {
                _context.Movies.Remove(item);
                _context.SaveChanges(true);
            }


            return RedirectToAction("Index");
        }
    }
}
