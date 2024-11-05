using Microsoft.EntityFrameworkCore;
using TP03SWII6.Models;

namespace TP03SWII6
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        DbSet<Product> Products { get; set; }
    }
}
