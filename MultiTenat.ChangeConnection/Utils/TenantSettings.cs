namespace MultiTenat.ChangeConnection.Utils
{
    public class TenantSettings
    {
        public Configuration Defaults { get; set; }
        public List<Tenant> Tenants { get; set; }
    }
    public class Configuration
    {
        public string DBProvider { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
    }

    public class Tenant
    {
        public string Name { get; set; } = null!;
        public string TID { get; set; } = null!;
        public string? ConnectionString { get; set; }
    }
}
