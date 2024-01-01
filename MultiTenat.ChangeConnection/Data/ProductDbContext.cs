using Microsoft.EntityFrameworkCore;
using MultiTenat.ChangeConnection.Models;
using MultiTenat.ChangeConnection.Services;

namespace MultiTenant.ChangeConnection.Data
{
    public class ProductDbContext : DbContext
    {
        public string TenantId { get; set; }
        private readonly ITenantService _tenantService;
        public ProductDbContext(DbContextOptions options, ITenantService tenantService) : base(options)
        {
            _tenantService = tenantService;
            TenantId = _tenantService.GetTenant()?.TID;
            Database.Migrate();
        }

        public DbSet<Products> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var tenantConnectionString = _tenantService.GetConnectionString();
            if (!string.IsNullOrEmpty(tenantConnectionString))
            {
                var DBProvider = _tenantService.GetDatabaseProvider();
                optionsBuilder.UseSqlServer(_tenantService.GetConnectionString(), options => options.EnableRetryOnFailure());
            }
        }
    }
}

