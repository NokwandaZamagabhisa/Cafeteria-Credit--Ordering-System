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

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-many relationship
            modelBuilder.Entity<MenuItem>()
                .HasOne(m => m.Restaurant)  // A MenuItem has one Restaurant
                .WithMany(r => r.MenuItems) // A Restaurant has many MenuItems
                .HasForeignKey(m => m.RestaurantId); // Foreign key in MenuItem

            base.OnModelCreating(modelBuilder);
        }
    }
}