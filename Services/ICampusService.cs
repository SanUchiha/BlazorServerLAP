using BlazorServerLAP.Dtos.Result.ResultCampus;
using BlazorServerLAP.Models;

namespace BlazorServerLAP.Services;

public interface ICampusService
{
    Task<List<Campus>> GetAllCampusAsync();
    Task<Campus> GetCampusAsync(int idCampus);
    Task<CreateCampusResultDTO> CreateCampusAsync(Campus campus);
    Task<UpdateCampusResultDTO> UpdateCampusAsync(Campus campus);
    Task<DeleteCampusResultDTO> DeleteCampusAsync(int idCampus);
}
