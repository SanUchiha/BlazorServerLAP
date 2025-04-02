namespace BlazorServerLAP.Models;

public partial class Campus
{
    public int IdCampus { get; set; }
    public string CampusName { get; set; } = null!;
    public string Organizer { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Country { get; set; } = null!;
    public decimal Prize { get; set; }
    public int MinimunAge { get; set; }
    public int MaximunAge { get; set; }
    public int Capacity { get; set; }
    public int BrotherDiscount { get; set; }
    public int OtherDiscount { get; set; }
    public string DescriptionCampus { get; set; } = null!;
    public string ImageCampus { get; set; } = null!;
    public DateOnly StartDay { get; set; }
    public DateOnly FinalDay { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly FinalTime { get; set; }
    public string PaymentMethodOne { get; set; } = null!;
    public string? PaymentMethodTwo { get; set; }
    public string? PaymentMethodThree { get; set; }

    public List<PersonCampus> PersonCampus { get; set; } = new List<PersonCampus>();
}
