using Domain.Entities.Models;

namespace Infrastructure.Repository.Contract;

public interface ICompanyRepository
{
    IEnumerable<Company> GetAllCompanies(bool trackChanges);
}