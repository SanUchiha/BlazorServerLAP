using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerLAP.Migrations
{
    /// <inheritdoc />
    public partial class AddCampusAndPersonCampusWithValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campus",
                columns: table => new
                {
                    IdCampus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampusName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Organizer = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Prize = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MinimunAge = table.Column<int>(type: "int", nullable: false),
                    MaximunAge = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    BrotherDiscount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    OtherDiscount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DescriptionCampus = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageCampus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDay = table.Column<DateTime>(type: "date", nullable: false),
                    FinalDay = table.Column<DateTime>(type: "date", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    FinalTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    PaymentMethodOne = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PaymentMethodTwo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PaymentMethodThree = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campus", x => x.IdCampus);
                });

            migrationBuilder.CreateTable(
                name: "PersonCampus",
                columns: table => new
                {
                    IdPerson = table.Column<int>(type: "int", nullable: false),
                    IdCampus = table.Column<int>(type: "int", nullable: false),
                    CampusIdCampus = table.Column<int>(type: "int", nullable: true),
                    PersonIdPerson = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCampus", x => new { x.IdPerson, x.IdCampus });
                    table.ForeignKey(
                        name: "FK_PersonCampus_Campus_CampusIdCampus",
                        column: x => x.CampusIdCampus,
                        principalTable: "Campus",
                        principalColumn: "IdCampus");
                    table.ForeignKey(
                        name: "FK_PersonCampus_Campus_IdCampus",
                        column: x => x.IdCampus,
                        principalTable: "Campus",
                        principalColumn: "IdCampus",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonCampus_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonCampus_Person_PersonIdPerson",
                        column: x => x.PersonIdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonCampus_CampusIdCampus",
                table: "PersonCampus",
                column: "CampusIdCampus");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCampus_IdCampus",
                table: "PersonCampus",
                column: "IdCampus");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCampus_PersonIdPerson",
                table: "PersonCampus",
                column: "PersonIdPerson");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonCampus");

            migrationBuilder.DropTable(
                name: "Campus");
        }
    }
}
