using Microsoft.EntityFrameworkCore;

namespace MultipleTenants.Data
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
