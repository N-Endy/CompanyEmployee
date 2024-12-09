using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Models;

public class Employee
{
    [Column("EmployeeId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Employee name is a required field")]
    [StringLength(50, ErrorMessage = "Employee name cannot be longer than 50 characters")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Employee Age is a required field")]
    public int Age { get; set; }
    
    [Required(ErrorMessage = "Employee Position is a required field")]
    [StringLength(20, ErrorMessage = "Employee position cannot be longer than 20 characters")]
    public string? Position { get; set; }
    
    [ForeignKey(nameof(Company))]
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }
}