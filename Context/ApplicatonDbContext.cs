using EmployeesManagment.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EmployeesManagment.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions)
        {

        }

        // Code - Approach

        public DbSet<Country> Countries { get; set; }

        public DbSet<County> Counties { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
