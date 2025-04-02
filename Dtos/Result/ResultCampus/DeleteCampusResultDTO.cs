using BlazorServerLAP.Models;

namespace BlazorServerLAP.Dtos.Result.ResultCampus;

public class UpdateCampusResultDTO : ResultDTO
{
    public int? CampusId { get; set; }
    public Campus? Campus { get; set; }
}
