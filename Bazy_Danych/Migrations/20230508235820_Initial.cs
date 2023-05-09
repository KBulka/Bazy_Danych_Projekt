using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bazy_Danych.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prowadzoncy",
                columns: table => new
                {
                    Id_Prowadzoncego = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prowadzoncy", x => x.Id_Prowadzoncego);
                });

            migrationBuilder.CreateTable(
                name: "Grupa",
                columns: table => new
                {
                    Id_Grupy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rok = table.Column<int>(type: "int", nullable: false),
                    Id_Prowadzoncego = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupa", x => x.Id_Grupy);
                    table.ForeignKey(
                        name: "FK_Grupa_Prowadzoncy_Id_Prowadzoncego",
                        column: x => x.Id_Prowadzoncego,
                        principalTable: "Prowadzoncy",
                        principalColumn: "Id_Prowadzoncego",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uczen",
                columns: table => new
                {
                    Id_ucznia = table.Column<int>(type: "int", nullable: false),
                    Imie = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Id_grupy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uczen", x => x.Id_ucznia);
                    table.ForeignKey(
                        name: "FK_Uczen_Grupa_Id_ucznia",
                        column: x => x.Id_ucznia,
                        principalTable: "Grupa",
                        principalColumn: "Id_Grupy",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                columns: table => new
                {
                    Id_projektu = table.Column<int>(type: "int", nullable: false),
                    Licza_etapow = table.Column<int>(type: "int", nullable: false),
                    Liczba_ukonczonych_etapow = table.Column<int>(type: "int", nullable: false),
                    Id_ucznia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekt", x => x.Id_projektu);
                    table.ForeignKey(
                        name: "FK_Projekt_Uczen_Id_projektu",
                        column: x => x.Id_projektu,
                        principalTable: "Uczen",
                        principalColumn: "Id_ucznia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Praca",
                columns: table => new
                {
                    Id_pracy = table.Column<int>(type: "int", nullable: false),
                    nr_etapu = table.Column<int>(type: "int", nullable: false),
                    Ocena = table.Column<int>(type: "int", nullable: false),
                    Zawartosc_pracy = table.Column<int>(type: "int", nullable: false),
                    Czy_ukonczony = table.Column<int>(type: "int", nullable: false),
                    Id_projektu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Praca", x => x.Id_pracy);
                    table.ForeignKey(
                        name: "FK_Praca_Projekt_Id_pracy",
                        column: x => x.Id_pracy,
                        principalTable: "Projekt",
                        principalColumn: "Id_projektu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grupa_Id_Prowadzoncego",
                table: "Grupa",
                column: "Id_Prowadzoncego");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Praca");

            migrationBuilder.DropTable(
                name: "Projekt");

            migrationBuilder.DropTable(
                name: "Uczen");

            migrationBuilder.DropTable(
                name: "Grupa");

            migrationBuilder.DropTable(
                name: "Prowadzoncy");
        }
    }
}
