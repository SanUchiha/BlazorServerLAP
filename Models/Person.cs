namespace BlazorServerLAP.Models;

public class Person
{
    public int IdPerson { get; set; }
    public string PersonName { get; set; } = null!;
    public string PersonLastName{ get; set; } = null!;
    public string? PersonLastNameSecond{ get; set; }
    public string PersonDni { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public string Address { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public bool HaveInjuries { get; set; } = false;
    public string? InjuriesDescription { get; set; }
    public bool TakeMedication { get; set; }
    public string? MedicationDescription { get; set; }
    public bool HaveAllergies { get; set; } = false;
    public string? AllergiesDescription { get; set; }
    public string GuardianName { get; set; } = null!;
    public string GuardianLastName { get; set; } = null!;
    public string? GuardianLastNameSecond { get; set; }
    public string GuardianDni { get; set; } = null!;
    public string PrincipalPhone { get; set; } = null!;
    public string? SecundaryPhone { get; set; }
    public string Email { get; set; } = null!;
    public bool AllowPhotos { get; set; }
    public bool Authorization { get; set; }
    public string? Signed { get; set; }
    public string? ShirtSize { get; set; }

    public virtual List<PersonCampus> PersonCampus { get; set; } = new List<PersonCampus>();
}