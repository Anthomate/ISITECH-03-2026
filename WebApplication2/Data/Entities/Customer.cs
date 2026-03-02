using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Data.Entities;
public class Customer : EntityBase
{
    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;
    [Required]
    [StringLength(50)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required]
    [StringLength(10)]
    [Phone]
    public string Phone { get; set; } = string.Empty;
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}