using CRUD_Operation.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Operation.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
