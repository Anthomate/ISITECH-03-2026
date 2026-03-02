namespace WebApplication2.Data.Entities;
public class StockRoom : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public ICollection<Product> Products { get; set; } = new List<Product>();
}