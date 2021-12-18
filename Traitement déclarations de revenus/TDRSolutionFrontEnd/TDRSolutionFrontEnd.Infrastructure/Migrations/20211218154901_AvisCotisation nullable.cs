using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TDRSolutionFrontEnd.Infrastructure.Migrations
{
    public partial class AvisCotisationnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeclarationRevenus_AvisCotisation_AvisCotisationId",
                table: "DeclarationRevenus");

            migrationBuilder.AlterColumn<int>(
                name: "AvisCotisationId",
                table: "DeclarationRevenus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DeclarationRevenus_AvisCotisation_AvisCotisationId",
                table: "DeclarationRevenus",
                column: "AvisCotisationId",
                principalTable: "AvisCotisation",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeclarationRevenus_AvisCotisation_AvisCotisationId",
                table: "DeclarationRevenus");

            migrationBuilder.AlterColumn<int>(
                name: "AvisCotisationId",
                table: "DeclarationRevenus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeclarationRevenus_AvisCotisation_AvisCotisationId",
                table: "DeclarationRevenus",
                column: "AvisCotisationId",
                principalTable: "AvisCotisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
