namespace WebApplication2.Data.Entities;

public class PriceHistory : EntityBase
{
    public decimal Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;
}