using Microsoft.EntityFrameworkCore;
using MultipleTenants.Data;

namespace MultipleTenants.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly BaseDbContext _dbContext;
        private DbSet<T> _dbSet;
        public GenericRepo(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public async Task<T> AddAsync(T item)
        {
            _dbSet.Add(item);
            await _dbContext.SaveChangesAsync();
            return item;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}
