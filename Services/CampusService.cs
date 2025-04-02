using BlazorServerLAP.Dtos.Result.ResultCampus;
using BlazorServerLAP.Models;
using BlazorServerLAP.Models.Configurations;

namespace BlazorServerLAP.Services;

public class CampusService : ICampusService
{
    private readonly ILogger<ICampusService> _logger;
    private readonly ApplicationDBContext _dbContext;

    public CampusService(ApplicationDBContext dbContext, ILogger<ICampusService> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public Task<CreateCampusResultDTO> CreateCampusAsync(Campus campus)
    {
        throw new NotImplementedException();
    }

    public Task<DeleteCampusResultDTO> DeleteCampusAsync(int idCampus)
    {
        throw new NotImplementedException();
    }

    public Task<List<Campus>> GetAllCampusAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Campus> GetCampusAsync(int idCampus)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateCampusResultDTO> UpdateCampusAsync(Campus campus)
    {
        throw new NotImplementedException();
    }
}
