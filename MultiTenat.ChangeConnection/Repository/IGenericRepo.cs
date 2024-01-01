namespace MultiTenant.ChangeConnection.Repository
{
    public interface IGenericRepo<T> where T : class
    {
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T item);
    }
}
