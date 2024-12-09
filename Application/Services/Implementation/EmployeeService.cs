using Application.LoggerService.LoggerManager;
using Application.Services.Contract;
using Infrastructure.Repository.Contract;

namespace Application.Services.Implementation;

public class EmployeeService : IEmployeeService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public EmployeeService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}