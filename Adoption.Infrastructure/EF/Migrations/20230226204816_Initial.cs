using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adoption.Infrastructure.EF.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "adoption");

            migrationBuilder.CreateTable(
                name: "Offerts",
                schema: "adoption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OffertStatus = table.Column<int>(type: "int", nullable: false, comment: "Komentarz do Offert Status"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NowePole = table.Column<string>(type: "nvarchar(69)", maxLength: 69, nullable: false, defaultValue: "wartość domyślna"),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                schema: "adoption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OffertId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OffertId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Offerts_OffertId",
                        column: x => x.OffertId,
                        principalSchema: "adoption",
                        principalTable: "Offerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Offerts_OffertId1",
                        column: x => x.OffertId1,
                        principalSchema: "adoption",
                        principalTable: "Offerts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_OffertId",
                schema: "adoption",
                table: "Applications",
                column: "OffertId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_OffertId1",
                schema: "adoption",
                table: "Applications",
                column: "OffertId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications",
                schema: "adoption");

            migrationBuilder.DropTable(
                name: "Offerts",
                schema: "adoption");
        }
    }
}
