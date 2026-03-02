namespace WebApplication2;

public class Order : EntityBase
{
    public int Number { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; } = null!; 
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}