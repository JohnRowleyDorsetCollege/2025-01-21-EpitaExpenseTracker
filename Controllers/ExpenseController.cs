using EpitaExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace EpitaExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        //CRUD 
        // Create a record
        // Retreive a record
        // Update a record
        // Delete a record

        private readonly ILogger<ExpenseController> _logger;
        private readonly ExpenseDbContext _context;

        public ExpenseController(ILogger<ExpenseController> logger, ExpenseDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index has been called");

            var expenses = _context.Expenses.ToList();

            foreach (var expense in expenses)
            {
                _logger.LogInformation($"Loading: {expense.Id}: {expense.Value}: {expense.Description}");
            }


            return View(expenses);
        }

        public IActionResult CreateEditExpense(int? Id)
        {
            if (Id is not null)
            {
                var item = _context.Expenses.Find(Id);
                return View(item);
            }
            return View();
        }

        public IActionResult CreateEditExpenseForm(Expense model)
        {
            if (model.Id == 0)
            {
                _logger.LogInformation($"Saving: {model.Id}: {model.Value}: {model.Description}");

                _context.Expenses.Add(model);
               
            } else
            {
                _logger.LogInformation($"Updating: {model.Id}: {model.Value}: {model.Description}");

                _context.Expenses.Update(model);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteExpense(int id)
        {
            _logger.LogInformation($"DeleteExpense");

            var item = _context.Expenses.Find(id);

            if (item is not null)
            {
                _context.Expenses.Remove(item);
                _context.SaveChanges(true);
            }


            return RedirectToAction("Index");
        }
    }

}

