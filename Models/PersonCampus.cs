namespace BlazorServerLAP.Models;

public class PersonCampus
{
    public int IdPerson { get; set; }
    public int IdCampus { get; set; }
    public DateTime RegistrationDate { get; set; } = DateTime.Now;

    public Person Person { get; set; } = null!;
    public Campus Campus { get; set; } = null!;
}