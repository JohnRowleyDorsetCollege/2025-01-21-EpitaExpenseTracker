using EpitaExpenseTracker.Models.DomainModels;

namespace EpitaExpenseTracker.Helpers
{
    public static class HelperExpenseCategories
    {
        public static List<ExpenseCategory> GetAllCategories()
        {
            return new List<ExpenseCategory>() {
                new ExpenseCategory() {Id =1 , Name="Category 1"},
                new ExpenseCategory() {Id =2 , Name="Category 2"},
                new ExpenseCategory() {Id =3 , Name="Category 3"},
                new ExpenseCategory() {Id =4 , Name="Category 4"}

            };
        }
    }
}
