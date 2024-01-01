using MultipleTenants.Data;

namespace MultipleTenants.Repository
{
    public class ProductGenericRepo<T> : GenericRepo<T>, IProductGenericRepo<T> where T : class
    {
        public ProductGenericRepo(ProductDbContext dbContext) : base(dbContext)
        {
        }
    }
}
