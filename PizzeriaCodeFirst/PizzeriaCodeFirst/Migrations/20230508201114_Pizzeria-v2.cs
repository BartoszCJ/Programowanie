using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzeriaCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Pizzeriav2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KlientId",
                table: "Zamowienies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuIId",
                table: "Zamowienies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PizzeriaId",
                table: "Zamowienies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PracownikId",
                table: "Zamowienies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PizzeriaId",
                table: "Pracowniks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZamowienieId",
                table: "Pracowniks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_Produktu",
                table: "Pizzerias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PracownikId",
                table: "Pizzerias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZamowienieId",
                table: "Pizzerias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZamowienieId",
                table: "Menus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZamowienieId",
                table: "Kliencis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienies_KlientId",
                table: "Zamowienies",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienies_MenuIId",
                table: "Zamowienies",
                column: "MenuIId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienies_PizzeriaId",
                table: "Zamowienies",
                column: "PizzeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienies_PracownikId",
                table: "Zamowienies",
                column: "PracownikId");

            migrationBuilder.CreateIndex(
                name: "IX_Pracowniks_PizzeriaId",
                table: "Pracowniks",
                column: "PizzeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pracowniks_ZamowienieId",
                table: "Pracowniks",
                column: "ZamowienieId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzerias_ID_Produktu",
                table: "Pizzerias",
                column: "ID_Produktu",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzerias_PracownikId",
                table: "Pizzerias",
                column: "PracownikId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzerias_ZamowienieId",
                table: "Pizzerias",
                column: "ZamowienieId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ZamowienieId",
                table: "Menus",
                column: "ZamowienieId");

            migrationBuilder.CreateIndex(
                name: "IX_Kliencis_ZamowienieId",
                table: "Kliencis",
                column: "ZamowienieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kliencis_Zamowienies_ZamowienieId",
                table: "Kliencis",
                column: "ZamowienieId",
                principalTable: "Zamowienies",
                principalColumn: "ID_Zamowienia");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Zamowienies_ZamowienieId",
                table: "Menus",
                column: "ZamowienieId",
                principalTable: "Zamowienies",
                principalColumn: "ID_Zamowienia");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzerias_Pracowniks_PracownikId",
                table: "Pizzerias",
                column: "PracownikId",
                principalTable: "Pracowniks",
                principalColumn: "ID_Pracownika");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzerias_Produktys_ID_Produktu",
                table: "Pizzerias",
                column: "ID_Produktu",
                principalTable: "Produktys",
                principalColumn: "ID_Produktu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzerias_Zamowienies_ZamowienieId",
                table: "Pizzerias",
                column: "ZamowienieId",
                principalTable: "Zamowienies",
                principalColumn: "ID_Zamowienia");

            migrationBuilder.AddForeignKey(
                name: "FK_Pracowniks_Pizzerias_PizzeriaId",
                table: "Pracowniks",
                column: "PizzeriaId",
                principalTable: "Pizzerias",
                principalColumn: "ID_Pizzeri");

            migrationBuilder.AddForeignKey(
                name: "FK_Pracowniks_Zamowienies_ZamowienieId",
                table: "Pracowniks",
                column: "ZamowienieId",
                principalTable: "Zamowienies",
                principalColumn: "ID_Zamowienia");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienies_Kliencis_KlientId",
                table: "Zamowienies",
                column: "KlientId",
                principalTable: "Kliencis",
                principalColumn: "ID_Klienta");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienies_Menus_MenuIId",
                table: "Zamowienies",
                column: "MenuIId",
                principalTable: "Menus",
                principalColumn: "ID_Menu");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienies_Pizzerias_PizzeriaId",
                table: "Zamowienies",
                column: "PizzeriaId",
                principalTable: "Pizzerias",
                principalColumn: "ID_Pizzeri");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienies_Pracowniks_PracownikId",
                table: "Zamowienies",
                column: "PracownikId",
                principalTable: "Pracowniks",
                principalColumn: "ID_Pracownika");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kliencis_Zamowienies_ZamowienieId",
                table: "Kliencis");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Zamowienies_ZamowienieId",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzerias_Pracowniks_PracownikId",
                table: "Pizzerias");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzerias_Produktys_ID_Produktu",
                table: "Pizzerias");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzerias_Zamowienies_ZamowienieId",
                table: "Pizzerias");

            migrationBuilder.DropForeignKey(
                name: "FK_Pracowniks_Pizzerias_PizzeriaId",
                table: "Pracowniks");

            migrationBuilder.DropForeignKey(
                name: "FK_Pracowniks_Zamowienies_ZamowienieId",
                table: "Pracowniks");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienies_Kliencis_KlientId",
                table: "Zamowienies");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienies_Menus_MenuIId",
                table: "Zamowienies");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienies_Pizzerias_PizzeriaId",
                table: "Zamowienies");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienies_Pracowniks_PracownikId",
                table: "Zamowienies");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienies_KlientId",
                table: "Zamowienies");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienies_MenuIId",
                table: "Zamowienies");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienies_PizzeriaId",
                table: "Zamowienies");

            migrationBuilder.DropIndex(
                name: "IX_Zamowienies_PracownikId",
                table: "Zamowienies");

            migrationBuilder.DropIndex(
                name: "IX_Pracowniks_PizzeriaId",
                table: "Pracowniks");

            migrationBuilder.DropIndex(
                name: "IX_Pracowniks_ZamowienieId",
                table: "Pracowniks");

            migrationBuilder.DropIndex(
                name: "IX_Pizzerias_ID_Produktu",
                table: "Pizzerias");

            migrationBuilder.DropIndex(
                name: "IX_Pizzerias_PracownikId",
                table: "Pizzerias");

            migrationBuilder.DropIndex(
                name: "IX_Pizzerias_ZamowienieId",
                table: "Pizzerias");

            migrationBuilder.DropIndex(
                name: "IX_Menus_ZamowienieId",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Kliencis_ZamowienieId",
                table: "Kliencis");

            migrationBuilder.DropColumn(
                name: "KlientId",
                table: "Zamowienies");

            migrationBuilder.DropColumn(
                name: "MenuIId",
                table: "Zamowienies");

            migrationBuilder.DropColumn(
                name: "PizzeriaId",
                table: "Zamowienies");

            migrationBuilder.DropColumn(
                name: "PracownikId",
                table: "Zamowienies");

            migrationBuilder.DropColumn(
                name: "PizzeriaId",
                table: "Pracowniks");

            migrationBuilder.DropColumn(
                name: "ZamowienieId",
                table: "Pracowniks");

            migrationBuilder.DropColumn(
                name: "ID_Produktu",
                table: "Pizzerias");

            migrationBuilder.DropColumn(
                name: "PracownikId",
                table: "Pizzerias");

            migrationBuilder.DropColumn(
                name: "ZamowienieId",
                table: "Pizzerias");

            migrationBuilder.DropColumn(
                name: "ZamowienieId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ZamowienieId",
                table: "Kliencis");
        }
    }
}
