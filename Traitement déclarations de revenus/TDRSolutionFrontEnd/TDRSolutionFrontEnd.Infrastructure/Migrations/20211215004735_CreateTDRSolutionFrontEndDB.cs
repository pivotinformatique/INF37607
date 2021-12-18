using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TDRSolutionFrontEnd.Infrastructure.Migrations
{
    public partial class CreateTDRSolutionFrontEndDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvisCotisation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontantDu = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvisCotisation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Courriel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephonePrincipal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneSecondaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Citoyennete = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeclarationRevenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsagerId = table.Column<int>(type: "int", nullable: false),
                    AvisCotisationId = table.Column<int>(type: "int", nullable: false),
                    RevenusEmploi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RevenusAutre = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Annee = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateReception = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeclarationRevenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeclarationRevenus_AvisCotisation_AvisCotisationId",
                        column: x => x.AvisCotisationId,
                        principalTable: "AvisCotisation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeclarationRevenus_Usagers_UsagerId",
                        column: x => x.UsagerId,
                        principalTable: "Usagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeclarationRevenus_AvisCotisationId",
                table: "DeclarationRevenus",
                column: "AvisCotisationId");

            migrationBuilder.CreateIndex(
                name: "IX_DeclarationRevenus_UsagerId",
                table: "DeclarationRevenus",
                column: "UsagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeclarationRevenus");

            migrationBuilder.DropTable(
                name: "AvisCotisation");

            migrationBuilder.DropTable(
                name: "Usagers");
        }
    }
}
