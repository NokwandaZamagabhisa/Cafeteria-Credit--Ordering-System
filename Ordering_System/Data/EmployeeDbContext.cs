using Microsoft.EntityFrameworkCore;
using Ordering_System.Models;

namespace Ordering_System.Data

{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {
            
        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
