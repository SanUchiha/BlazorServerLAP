using BlazorServerLAP.Attributes;

namespace BlazorServerLAP.Models;

public partial class Campus
{
    public int IdCampus { get; set; }
    public required string CampusName { get; set; } = null!;
    public required string Organizer { get; set; } = null!;
    public required string Address { get; set; } = null!;
    public required string Location { get; set; } = null!;
    public required string City { get; set; } = null!;
    public required string Country { get; set; } = null!;
    public decimal Prize { get; set; }
    public int MinimunAge { get; set; }
    public int MaximunAge { get; set; }
    public int Capacity { get; set; }
    public int BrotherDiscount { get; set; }
    public int OtherDiscount { get; set; }
    public required string DescriptionCampus { get; set; } = null!;
    public required string ImageCampus { get; set; } = null!;
    public DateOnly StartDay { get; set; }
    public DateOnly FinalDay { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly FinalTime { get; set; }
    public required string PaymentMethodOne { get; set; } = null!;
    public string? PaymentMethodTwo { get; set; }
    public string? PaymentMethodThree { get; set; }
    [PasswordValidation]
    public required string Password { get; set; }

    public List<PersonCampus> PersonCampus { get; set; } = new List<PersonCampus>();
}
