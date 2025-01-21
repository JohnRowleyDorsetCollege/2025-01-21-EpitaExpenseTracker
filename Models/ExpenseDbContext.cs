using Microsoft.EntityFrameworkCore;

namespace EpitaExpenseTracker.Models
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
