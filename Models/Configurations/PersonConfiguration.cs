using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerLAP.Models.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(p => p.IdPerson);
        builder.Property(p => p.PersonName).IsRequired().HasMaxLength(30);
        builder.Property(p => p.PersonLastName).IsRequired().HasMaxLength(30);
        builder.Property(p => p.PersonLastNameSecond).HasMaxLength(30);
        builder.Property(p => p.PersonDni).IsRequired().HasMaxLength(9).IsFixedLength();
        builder.Property(p => p.BirthDate).IsRequired().HasColumnType("date");
        builder.Property(p => p.Address).IsRequired();
        builder.Property(p => p.Country).IsRequired();
        builder.Property(p => p.PostalCode).IsRequired().HasMaxLength(5).IsFixedLength();
        builder.Property(p => p.InjuriesDescription).HasMaxLength(500);
        builder.Property(p => p.MedicationDescription).HasMaxLength(500);
        builder.Property(p => p.AllergiesDescription).HasMaxLength(500);
        builder.Property(p => p.GuardianName).IsRequired().HasMaxLength(30);
        builder.Property(p => p.GuardianLastName).IsRequired().HasMaxLength(30);
        builder.Property(p => p.GuardianLastNameSecond).HasMaxLength(30);
        builder.Property(p => p.GuardianDni).IsRequired().HasMaxLength(9).IsFixedLength();
        builder.Property(p => p.PrincipalPhone).IsRequired().HasMaxLength(9).IsFixedLength();
        builder.Property(p => p.SecundaryPhone).HasMaxLength(9).IsFixedLength();
        builder.Property(p => p.Email).IsRequired().HasMaxLength(200);
        builder.Property(p => p.Signed).HasMaxLength(500);
        builder.Property(p => p.ShirtSize).HasMaxLength(5);
    }
}
