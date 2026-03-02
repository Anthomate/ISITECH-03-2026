using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Data.Entities;
public class Category : EntityBase
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    public Guid? ParentId { get; set; }
    public Category? Parent { get; set; }
    public ICollection<Category> Children { get; set; } = new List<Category>();
    public ICollection<Product> Products { get; set; } = new List<Product>();
}