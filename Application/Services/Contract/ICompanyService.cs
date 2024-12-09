using Domain.Entities.Models;

namespace Application.Services.Contract;

public interface ICompanyService
{
    IEnumerable<Company> GetAllCompanies(bool trackChanges);
}