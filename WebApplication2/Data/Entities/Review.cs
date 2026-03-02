namespace WebApplication2.Data.Entities;

public class Review : EntityBase
{
    public int Rating { get; set; }
    public string? Comment { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}