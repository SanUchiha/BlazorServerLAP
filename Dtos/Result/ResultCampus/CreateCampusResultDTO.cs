using BlazorServerLAP.Models;

namespace BlazorServerLAP.Dtos.Result.ResultCampus;

public class CreateCampusResultDTO : ResultDTO
{
    public int? CampusId { get; set; }
    public Campus? Campus { get; set; }
}
