using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Models;

public class Company
{
    [Column("CompanyId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Company name is a required field")]
    [MaxLength(50, ErrorMessage = "Company name cannot be more than 50 characters")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Company address is a required field")]
    [MaxLength(50, ErrorMessage = "Company address cannot be more than 50 characters")]
    public string? Address { get; set; }
    
    [MaxLength(20, ErrorMessage = "Country cannot be more than 20 characters")]
    public string? Country { get; set; }
    
    public ICollection<Employee>? Employees { get; set; }
}