using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasData
        (
            new Employee
            {
                Id = new Guid("c6587829-0fb0-4e55-bba6-2d741c18e900"),
                Name = "John Doe",
                Age = 26,
                Position = "Software Engineer",
                CompanyId = new Guid("26f430d4-9da9-4739-9841-d0bc08128ce2")
            },
            new Employee
            {
                Id = new Guid("da7e6c07-4d9d-4920-ab0a-d525254346ed"),
                Name = "Jana McLeaf",
                Age = 30,
                Position = "Software developer",
                CompanyId = new Guid("f943e9f6-4d1a-4fbd-9cfc-fc68d09f5ef9")
            }
        );
    }
}