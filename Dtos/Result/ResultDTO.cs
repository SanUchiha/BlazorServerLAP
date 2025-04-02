namespace BlazorServerLAP.Dtos.Result;

public class ResultDTO
{
    public bool IsSuccess { get; set; } = false;
    public string ErrorMessage { get; set; } = default!;
    public string ErrorType { get; set; } = default!;
    public string Message { get; set; } = default!;
}
