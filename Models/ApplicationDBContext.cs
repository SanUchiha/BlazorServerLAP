using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServerLAP.Models;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public DbSet<Person> Person => Set<Person>();
    public DbSet<Campus> Campus => Set<Campus>();
    public DbSet<PersonCampus> PersonCampus => Set<PersonCampus>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración de Person
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(p => p.IdPerson);
            entity.Property(p => p.PersonName).IsRequired().HasMaxLength(30);
            entity.Property(p => p.PersonLastName).IsRequired().HasMaxLength(30);
            entity.Property(p => p.PersonLastNameSecond).HasMaxLength(30);
            entity.Property(p => p.PersonDni).IsRequired().HasMaxLength(9).IsFixedLength();
            entity.Property(p => p.BirthDate).IsRequired().HasColumnType("date");
            entity.Property(p => p.Address).IsRequired();
            entity.Property(p => p.Country).IsRequired();
            entity.Property(p => p.PostalCode).IsRequired().HasMaxLength(5).IsFixedLength();
            entity.Property(p => p.InjuriesDescription).HasMaxLength(500);
            entity.Property(p => p.MedicationDescription).HasMaxLength(500);
            entity.Property(p => p.AllergiesDescription).HasMaxLength(500);
            entity.Property(p => p.GuardianName).IsRequired().HasMaxLength(30);
            entity.Property(p => p.GuardianLastName).IsRequired().HasMaxLength(30);
            entity.Property(p => p.GuardianLastNameSecond).HasMaxLength(30);
            entity.Property(p => p.GuardianDni).IsRequired().HasMaxLength(9).IsFixedLength();
            entity.Property(p => p.PrincipalPhone).IsRequired().HasMaxLength(9).IsFixedLength();
            entity.Property(p => p.SecundaryPhone).HasMaxLength(9).IsFixedLength();
            entity.Property(p => p.Email).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Signed).HasMaxLength(500);
            entity.Property(p => p.ShirtSize).HasMaxLength(5);
        });

        ValueConverter<DateOnly, DateTime> dateOnlyConverter = new(
            d => d.ToDateTime(TimeOnly.MinValue),
            d => DateOnly.FromDateTime(d));

        ValueConverter<TimeOnly, TimeSpan> timeOnlyConverter = new(
            t => t.ToTimeSpan(),
            t => TimeOnly.FromTimeSpan(t));

        // Configuración de Campus
        modelBuilder.Entity<Campus>(entity =>
        {
            entity.HasKey(c => c.IdCampus);
            entity.Property(c => c.CampusName).IsRequired().HasMaxLength(150);
            entity.Property(c => c.Organizer).IsRequired().HasMaxLength(150);
            entity.Property(c => c.Address).IsRequired().HasMaxLength(500);
            entity.Property(c => c.Location).IsRequired().HasMaxLength(30);
            entity.Property(c => c.City).IsRequired().HasMaxLength(30);
            entity.Property(c => c.Country).IsRequired().HasMaxLength(30);
            entity.Property(c => c.Prize).IsRequired().HasColumnType("decimal(10,2)");
            entity.Property(c => c.MinimunAge).IsRequired();
            entity.Property(c => c.MaximunAge).IsRequired();
            entity.Property(c => c.Capacity).IsRequired();
            entity.Property(c => c.BrotherDiscount).HasDefaultValue(0);
            entity.Property(c => c.OtherDiscount).HasDefaultValue(0);
            entity.Property(c => c.DescriptionCampus).IsRequired().HasMaxLength(500);
            entity.Property(c => c.ImageCampus).IsRequired();
            entity.Property(c => c.StartDay).HasConversion(dateOnlyConverter).HasColumnType("date");
            entity.Property(c => c.FinalDay).HasConversion(dateOnlyConverter).HasColumnType("date");
            entity.Property(c => c.StartTime).HasConversion(timeOnlyConverter).HasColumnType("time");
            entity.Property(c => c.FinalTime).HasConversion(timeOnlyConverter).HasColumnType("time");
            entity.Property(c => c.PaymentMethodOne).IsRequired().HasMaxLength(500);
            entity.Property(c => c.PaymentMethodTwo).HasMaxLength(500);
            entity.Property(c => c.PaymentMethodThree).HasMaxLength(500);
            entity.Property(c => c.Password).IsRequired().HasMaxLength(50);
        });

        // Configuración de la relación muchos a muchos entre Person y Campus
        modelBuilder.Entity<PersonCampus>(entity =>
        {
            entity.HasKey(pc => new { pc.IdPerson, pc.IdCampus });

            entity.HasOne(pc => pc.Person)
                .WithMany()
                .HasForeignKey(pc => pc.IdPerson)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(pc => pc.Campus)
                .WithMany()
                .HasForeignKey(pc => pc.IdCampus)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
