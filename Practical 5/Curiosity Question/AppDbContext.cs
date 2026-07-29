using Microsoft.EntityFrameworkCore;
using Pratical_5_CQ.Models;
namespace Pratical_5_CQ.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
