using Microsoft.EntityFrameworkCore;
using MultipleTenants.Models;

namespace MultipleTenants.Data
{
    public class UserDbContext : BaseDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
