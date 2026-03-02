using System.ComponentModel.DataAnnotations;

namespace WebApplication2;

public class Category : EntityBase
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    public ICollection<Product> Products { get; set; } = new List<Product>();
}