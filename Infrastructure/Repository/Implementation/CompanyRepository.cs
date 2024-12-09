using Domain.Entities.Models;
using Infrastructure.DataAccess;
using Infrastructure.Repository.Contract;

namespace Infrastructure.Repository.Implementation;

public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RepositoryContext repositoryContext) : 
        base(repositoryContext)
    {
    }

    public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
}