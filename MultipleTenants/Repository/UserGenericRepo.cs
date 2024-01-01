using MultipleTenants.Data;

namespace MultipleTenants.Repository
{
    public class UserGenericRepo<T> : GenericRepo<T>, IUserGenericRepo<T> where T : class
    {
        public UserGenericRepo(UserDbContext dbContext) : base(dbContext)
        {
        }
    }
}
