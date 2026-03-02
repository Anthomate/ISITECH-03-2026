using System.ComponentModel.DataAnnotations;

namespace WebApplication2;

public class Product : EntityBase
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [StringLength(150)]
    public string Description { get; set; } = string.Empty;
    [Required]
    public decimal Price { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}