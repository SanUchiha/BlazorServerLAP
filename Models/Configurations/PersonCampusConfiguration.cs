using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorServerLAP.Models.Configurations;

public class PersonCampusConfiguration : IEntityTypeConfiguration<PersonCampus>
{
    public void Configure(EntityTypeBuilder<PersonCampus> builder)
    {
        builder.HasKey(pc => new { pc.IdPerson, pc.IdCampus });
        builder.Property(p => p.RegistrationDate).IsRequired().HasColumnType("date");

        builder.HasOne(pc => pc.Person)
            .WithMany()
            .HasForeignKey(pc => pc.IdPerson)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(pc => pc.Campus)
            .WithMany()
            .HasForeignKey(pc => pc.IdCampus)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
