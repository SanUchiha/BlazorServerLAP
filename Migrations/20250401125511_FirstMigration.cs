using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerLAP.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonLastNameSecond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonDni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HaveInjuries = table.Column<bool>(type: "bit", nullable: false),
                    InjuriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TakeMedication = table.Column<bool>(type: "bit", nullable: false),
                    MedicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaveAllergies = table.Column<bool>(type: "bit", nullable: false),
                    AllergiesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianLastNameSecond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuardianDni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipalPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecundaryPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowPhotos = table.Column<bool>(type: "bit", nullable: false),
                    Authorization = table.Column<bool>(type: "bit", nullable: false),
                    Signed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShirtSize = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
