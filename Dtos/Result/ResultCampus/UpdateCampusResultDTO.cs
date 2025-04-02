using BlazorServerLAP.Models;

namespace BlazorServerLAP.Dtos.Result.ResultCampus;

public class DeleteCampusResultDTO : ResultDTO
{
    public int? CampusId { get; set; }
    public Campus? Campus { get; set; }
}
