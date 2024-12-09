using Application.LoggerService.LoggerManager;
using Application.Services.Contract;
using Domain.Entities.Models;
using Infrastructure.Repository.Contract;

namespace Application.Services.Implementation;

public class CompanyService : ICompanyService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public CompanyService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public IEnumerable<Company> GetAllCompanies(bool trackChanges)
    {
        try
        {
            var companies = _repository.Company.GetAllCompanies(trackChanges);
            return companies;
        }
        catch (Exception e)
        {
            _logger.LogError($"Something went wrong in the {nameof(GetAllCompanies)} service method: {e.Message}");
            throw;
        }
    }
}