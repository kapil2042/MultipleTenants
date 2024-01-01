namespace MultipleTenants.Repository
{
    public interface IProductGenericRepo<T> : IGenericRepo<T> where T : class
    {
    }
}
