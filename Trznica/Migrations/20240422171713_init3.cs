using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trznica.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_vrstaStolas",
                table: "vrstaStolas");

            migrationBuilder.RenameTable(
                name: "vrstaStolas",
                newName: "VrstaStola");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VrstaStola",
                table: "VrstaStola",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VrstaStola",
                table: "VrstaStola");

            migrationBuilder.RenameTable(
                name: "VrstaStola",
                newName: "vrstaStolas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vrstaStolas",
                table: "vrstaStolas",
                column: "Id");
        }
    }
}
