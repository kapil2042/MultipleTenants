using MultiTenat.ChangeConnection.Utils;

namespace MultiTenat.ChangeConnection.Services
{
    public interface ITenantService
    {
        string GetDatabaseProvider();
        string GetConnectionString();
        Tenant GetTenant();
    }
}
