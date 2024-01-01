namespace MultipleTenants.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Rate { get; set; }
    }
}
