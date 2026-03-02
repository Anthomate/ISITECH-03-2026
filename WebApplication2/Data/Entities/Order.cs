using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Data.Entities;
public class Order : EntityBase
{
    public int Number { get; set; }
    public Guid CustomerId { get; set; }
    [Required]
    [StringLength(250)]
    public string DeliveryAddress { get; set; } = string.Empty;
    [Required]
    [StringLength(250)]
    public string FactureAddress { get; set; } = string.Empty;
    public Customer Customer { get; set; } = null!; 
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}