namespace MultipleTenants.Repository
{
    public interface IUserGenericRepo<T> : IGenericRepo<T> where T : class
    {
    }
}
