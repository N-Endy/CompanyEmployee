using Domain.Entities.Models;
using Infrastructure.DataAccess;
using Infrastructure.Repository.Contract;

namespace Infrastructure.Repository.Implementation;

public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    public EmployeeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
}