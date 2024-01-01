using Microsoft.EntityFrameworkCore;
using MultipleTenants.Models;

namespace MultipleTenants.Data
{
    public class ProductDbContext : BaseDbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
