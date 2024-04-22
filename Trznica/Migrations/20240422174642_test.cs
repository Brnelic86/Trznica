using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trznica.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OIB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lozinka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VrstaKorisnika = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RacunKorisnik = table.Column<int>(type: "int", nullable: false),
                    TipRacuna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iznos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRacuna = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ugovor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RedniBroj = table.Column<int>(type: "int", nullable: false),
                    UgovorKorsinik = table.Column<int>(type: "int", nullable: false),
                    TipUgovora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iznos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumOdobrenja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumIsteka = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UgovorStol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugovor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZahtjevUgovor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RedniBroj = table.Column<int>(type: "int", nullable: false),
                    ZahtjevUgovorKorisnik = table.Column<int>(type: "int", nullable: false),
                    TipUgovora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumZahtjeva = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZahtjevUgovorStol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZahtjevUgovor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "Ugovor");

            migrationBuilder.DropTable(
                name: "ZahtjevUgovor");
        }
    }
}
