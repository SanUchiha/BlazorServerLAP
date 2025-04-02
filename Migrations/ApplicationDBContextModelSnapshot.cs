﻿// <auto-generated />
using System;
using BlazorServerLAP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServerLAP.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorServerLAP.Models.Campus", b =>
                {
                    b.Property<int>("IdCampus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCampus"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("BrotherDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("CampusName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("DescriptionCampus")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FinalDay")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("FinalTime")
                        .HasColumnType("time");

                    b.Property<string>("ImageCampus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("MaximunAge")
                        .HasColumnType("int");

                    b.Property<int>("MinimunAge")
                        .HasColumnType("int");

                    b.Property<string>("Organizer")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("OtherDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("PaymentMethodOne")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PaymentMethodThree")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PaymentMethodTwo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("Prize")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("StartDay")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("IdCampus");

                    b.ToTable("Campus");
                });

            modelBuilder.Entity("BlazorServerLAP.Models.Person", b =>
                {
                    b.Property<int>("IdPerson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerson"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AllergiesDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("AllowPhotos")
                        .HasColumnType("bit");

                    b.Property<bool>("Authorization")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("GuardianDni")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nchar(9)")
                        .IsFixedLength();

                    b.Property<string>("GuardianLastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("GuardianLastNameSecond")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("GuardianName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("HaveAllergies")
                        .HasColumnType("bit");

                    b.Property<bool>("HaveInjuries")
                        .HasColumnType("bit");

                    b.Property<string>("InjuriesDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MedicationDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PersonDni")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nchar(9)")
                        .IsFixedLength();

                    b.Property<string>("PersonLastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PersonLastNameSecond")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .IsFixedLength();

                    b.Property<string>("PrincipalPhone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nchar(9)")
                        .IsFixedLength();

                    b.Property<string>("SecundaryPhone")
                        .HasMaxLength(9)
                        .HasColumnType("nchar(9)")
                        .IsFixedLength();

                    b.Property<string>("ShirtSize")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Signed")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("TakeMedication")
                        .HasColumnType("bit");

                    b.HasKey("IdPerson");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("BlazorServerLAP.Models.PersonCampus", b =>
                {
                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.Property<int>("IdCampus")
                        .HasColumnType("int");

                    b.Property<int?>("CampusIdCampus")
                        .HasColumnType("int");

                    b.Property<int?>("PersonIdPerson")
                        .HasColumnType("int");

                    b.HasKey("IdPerson", "IdCampus");

                    b.HasIndex("CampusIdCampus");

                    b.HasIndex("IdCampus");

                    b.HasIndex("PersonIdPerson");

                    b.ToTable("PersonCampus");
                });

            modelBuilder.Entity("BlazorServerLAP.Models.PersonCampus", b =>
                {
                    b.HasOne("BlazorServerLAP.Models.Campus", null)
                        .WithMany("PersonCampus")
                        .HasForeignKey("CampusIdCampus");

                    b.HasOne("BlazorServerLAP.Models.Campus", "Campus")
                        .WithMany()
                        .HasForeignKey("IdCampus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorServerLAP.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorServerLAP.Models.Person", null)
                        .WithMany("PersonCampus")
                        .HasForeignKey("PersonIdPerson");

                    b.Navigation("Campus");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("BlazorServerLAP.Models.Campus", b =>
                {
                    b.Navigation("PersonCampus");
                });

            modelBuilder.Entity("BlazorServerLAP.Models.Person", b =>
                {
                    b.Navigation("PersonCampus");
                });
#pragma warning restore 612, 618
        }
    }
}
