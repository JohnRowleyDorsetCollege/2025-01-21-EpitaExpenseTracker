using EpitaExpenseTracker.Models.DomainModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EpitaExpenseTracker.Models.ViewModels
{
    public class ExpenseFormViewModel
    {
        public Expense Expense { get; set; }

        //public List<SelectListItem> ExpenseCategories = new List<SelectListItem>();
        public List<SelectListItem> ExpenseCategories = new List<SelectListItem>();

    }
}
