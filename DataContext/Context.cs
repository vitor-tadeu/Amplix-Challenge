using Company.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.DataContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> dbContext) : base(dbContext)
        {
            Database.EnsureCreated();
        }
        public DbSet<Client> Clients { get; set; }
    }
}
