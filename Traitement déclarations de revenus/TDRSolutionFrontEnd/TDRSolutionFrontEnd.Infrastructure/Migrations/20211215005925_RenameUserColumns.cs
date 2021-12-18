using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TDRSolutionFrontEnd.Infrastructure.Migrations
{
    public partial class RenameUserColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Usagers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Usagers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "MotDePasse",
                table: "Usagers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Courriel",
                table: "Usagers",
                newName: "Email");

            migrationBuilder.AddColumn<bool>(
                name: "IsSubmitted",
                table: "DeclarationRevenus",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubmitted",
                table: "DeclarationRevenus");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usagers",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Usagers",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Usagers",
                newName: "MotDePasse");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usagers",
                newName: "Courriel");
        }
    }
}
