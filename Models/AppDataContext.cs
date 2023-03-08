using Microsoft.EntityFrameworkCore;

namespace iapCoursework2.Models
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}