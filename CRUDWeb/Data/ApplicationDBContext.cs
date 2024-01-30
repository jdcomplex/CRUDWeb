using CRUDWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CRUDWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Code to seed data
            builder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "IT", DisplayOrder = 1 },
                new Category { CategoryID = 2, CategoryName = "Development", DisplayOrder = 2 },
                new Category { CategoryID = 3, CategoryName = "Business", DisplayOrder = 3 }
                );

        }
    }
}
