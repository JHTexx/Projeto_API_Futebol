using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoFutebolAPI_Final.Migrations
{
    public partial class SeedJogadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Posicao = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroCamisa = table.Column<int>(type: "INTEGER", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "DataNascimento", "Nome", "NumeroCamisa", "Posicao", "Time" },
                values: new object[] { 1, new DateTime(2000, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinicius Junior", 7, "Atacante", "Real Madrid" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "DataNascimento", "Nome", "NumeroCamisa", "Posicao", "Time" },
                values: new object[] { 2, new DateTime(2001, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodrygo", 11, "Atacante", "Real Madrid" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "DataNascimento", "Nome", "NumeroCamisa", "Posicao", "Time" },
                values: new object[] { 3, new DateTime(2006, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Endrick", 19, "Atacante", "Real Madrid" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "DataNascimento", "Nome", "NumeroCamisa", "Posicao", "Time" },
                values: new object[] { 4, new DateTime(1992, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neymar", 10, "Atacante", "Santos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogadores");
        }
    }
}
