using Microsoft.EntityFrameworkCore;
using TP03SWII6.Models;

/*
CB3011836 - Ketheleen Cristine Simão dos Santos
CB3020282 - Ronald Pereira Evangelista
*/

namespace TP03SWII6
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
