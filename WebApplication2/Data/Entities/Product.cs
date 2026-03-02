using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Data.Entities;

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
    public ICollection<PriceHistory> PriceHistories { get; set; } = new List<PriceHistory>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    [NotMapped]
    public float Rating => Reviews.Any() ? (float)Reviews.Average(r => r.Rating) : 0f;
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public Guid StockRoomId { get; set; }
    public StockRoom StockRoom { get; set; } = null!;
}