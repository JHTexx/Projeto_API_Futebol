using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoFutebolAPI_Completo.Migrations
{
    public partial class Inicial : Migration
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
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Peso = table.Column<double>(type: "REAL", nullable: false),
                    Altura = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 1, 1.76, new DateTime(2000, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vinicius Junior", 7, 73.0, "Atacante", "Real Madrid" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 2, 1.74, new DateTime(2001, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodrygo", 11, 68.0, "Atacante", "Real Madrid" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 3, 1.75, new DateTime(2006, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Endrick", 9, 73.0, "Atacante", "Real Madrid" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 4, 1.75, new DateTime(1992, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neymar", 10, 69.0, "Atacante", "Al-Hilal" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 5, 1.8500000000000001, new DateTime(1992, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casemiro", 5, 84.0, "Volante", "Manchester United" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 6, 1.9099999999999999, new DateTime(1992, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alisson", 1, 91.0, "Goleiro", "Liverpool" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 7, 1.8600000000000001, new DateTime(1998, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Éder Militão", 3, 78.0, "Zagueiro", "Real Madrid" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 8, 1.8200000000000001, new DateTime(1997, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruno Guimarães", 39, 74.0, "Meio-campo", "Newcastle" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 9, 1.76, new DateTime(1996, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raphinha", 11, 68.0, "Atacante", "Barcelona" });

            migrationBuilder.InsertData(
                table: "Jogadores",
                columns: new[] { "Id", "Altura", "DataNascimento", "Nome", "NumeroCamisa", "Peso", "Posicao", "Time" },
                values: new object[] { 10, 1.8400000000000001, new DateTime(1991, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danilo", 6, 78.0, "Lateral", "Juventus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogadores");
        }
    }
}
