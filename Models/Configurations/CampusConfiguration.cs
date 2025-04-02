using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorServerLAP.Models.Configurations;

public class CampusConfiguration : IEntityTypeConfiguration<Campus>
{
    public void Configure(EntityTypeBuilder<Campus> builder)
    {
        ValueConverter<DateOnly, DateTime> dateOnlyConverter = new(
            d => d.ToDateTime(TimeOnly.MinValue),
            d => DateOnly.FromDateTime(d));

        ValueConverter<TimeOnly, TimeSpan> timeOnlyConverter = new(
            t => t.ToTimeSpan(),
            t => TimeOnly.FromTimeSpan(t));

        builder.HasKey(c => c.IdCampus);
        builder.Property(c => c.CampusName).IsRequired().HasMaxLength(150);
        builder.Property(c => c.Organizer).IsRequired().HasMaxLength(150);
        builder.Property(c => c.Address).IsRequired().HasMaxLength(500);
        builder.Property(c => c.Location).IsRequired().HasMaxLength(30);
        builder.Property(c => c.City).IsRequired().HasMaxLength(30);
        builder.Property(c => c.Country).IsRequired().HasMaxLength(30);
        builder.Property(c => c.Prize).IsRequired().HasColumnType("decimal(10,2)");
        builder.Property(c => c.MinimunAge).IsRequired();
        builder.Property(c => c.MaximunAge).IsRequired();
        builder.Property(c => c.Capacity).IsRequired();
        builder.Property(c => c.BrotherDiscount).HasDefaultValue(0);
        builder.Property(c => c.OtherDiscount).HasDefaultValue(0);
        builder.Property(c => c.DescriptionCampus).IsRequired().HasMaxLength(500);
        builder.Property(c => c.ImageCampus).IsRequired();
        builder.Property(c => c.StartDay).HasConversion(dateOnlyConverter).HasColumnType("date");
        builder.Property(c => c.FinalDay).HasConversion(dateOnlyConverter).HasColumnType("date");
        builder.Property(c => c.StartTime).HasConversion(timeOnlyConverter).HasColumnType("time");
        builder.Property(c => c.FinalTime).HasConversion(timeOnlyConverter).HasColumnType("time");
        builder.Property(c => c.PaymentMethodOne).IsRequired().HasMaxLength(500);
        builder.Property(c => c.PaymentMethodTwo).HasMaxLength(500);
        builder.Property(c => c.PaymentMethodThree).HasMaxLength(500);
        builder.Property(c => c.Password).IsRequired().HasMaxLength(50);
    }
}
