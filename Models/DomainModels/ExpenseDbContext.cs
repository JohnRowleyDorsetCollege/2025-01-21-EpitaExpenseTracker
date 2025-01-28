using Microsoft.EntityFrameworkCore;

namespace EpitaExpenseTracker.Models.DomainModels
{
    public class ExpenseDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public ExpenseDbContext(DbContextOptions<ExpenseDbContext> options) : base(options)
        {

        }
    }
}
