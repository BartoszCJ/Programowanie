using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Pizzeriav1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kliencis",
                columns: table => new
                {
                    ID_Klienta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kliencis", x => x.ID_Klienta);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID_Menu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa_Dania = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<int>(type: "int", nullable: false),
                    Rabat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID_Menu);
                });

            migrationBuilder.CreateTable(
                name: "Pizzerias",
                columns: table => new
                {
                    ID_Pizzeri = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzerias", x => x.ID_Pizzeri);
                });

            migrationBuilder.CreateTable(
                name: "Pracowniks",
                columns: table => new
                {
                    ID_Pracownika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stawka = table.Column<int>(type: "int", nullable: false),
                    Stanowisko = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracowniks", x => x.ID_Pracownika);
                });

            migrationBuilder.CreateTable(
                name: "Produktys",
                columns: table => new
                {
                    ID_Produktu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa_Produktu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilosc_Produktu = table.Column<int>(type: "int", nullable: false),
                    Max_Ilosc_Produktu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produktys", x => x.ID_Produktu);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienies",
                columns: table => new
                {
                    ID_Zamowienia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Godz = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienies", x => x.ID_Zamowienia);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kliencis");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Pizzerias");

            migrationBuilder.DropTable(
                name: "Pracowniks");

            migrationBuilder.DropTable(
                name: "Produktys");

            migrationBuilder.DropTable(
                name: "Zamowienies");
        }
    }
}
