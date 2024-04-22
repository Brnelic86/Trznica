using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trznica.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CijenaDan",
                table: "vrstaStolas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CijenaGodina",
                table: "vrstaStolas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CijenaMjesec",
                table: "vrstaStolas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "vrstaStolas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "vrstaStolas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CijenaDan",
                table: "vrstaStolas");

            migrationBuilder.DropColumn(
                name: "CijenaGodina",
                table: "vrstaStolas");

            migrationBuilder.DropColumn(
                name: "CijenaMjesec",
                table: "vrstaStolas");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "vrstaStolas");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "vrstaStolas");
        }
    }
}
