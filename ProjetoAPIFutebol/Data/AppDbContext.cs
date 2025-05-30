using Microsoft.EntityFrameworkCore;
using GerenciamentoFutebolAPI.Models;

namespace GerenciamentoFutebolAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Jogador> Jogadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogador>().HasData(
                new Jogador { Id = 1, Nome = "Vinicius Junior", Posicao = "Atacante", NumeroCamisa = 7, Time = "Real Madrid", DataNascimento = new DateTime(2000, 7, 12), Peso = 73, Altura = 1.76 },
                new Jogador { Id = 2, Nome = "Rodrygo", Posicao = "Atacante", NumeroCamisa = 11, Time = "Real Madrid", DataNascimento = new DateTime(2001, 1, 9), Peso = 68, Altura = 1.74 },
                new Jogador { Id = 3, Nome = "Endrick", Posicao = "Atacante", NumeroCamisa = 9, Time = "Real Madrid", DataNascimento = new DateTime(2006, 7, 21), Peso = 73, Altura = 1.75 },
                new Jogador { Id = 4, Nome = "Neymar", Posicao = "Atacante", NumeroCamisa = 10, Time = "Al-Hilal", DataNascimento = new DateTime(1992, 2, 5), Peso = 69, Altura = 1.75 },
                new Jogador { Id = 5, Nome = "Casemiro", Posicao = "Volante", NumeroCamisa = 5, Time = "Manchester United", DataNascimento = new DateTime(1992, 2, 23), Peso = 84, Altura = 1.85 },
                new Jogador { Id = 6, Nome = "Alisson", Posicao = "Goleiro", NumeroCamisa = 1, Time = "Liverpool", DataNascimento = new DateTime(1992, 10, 2), Peso = 91, Altura = 1.91 },
                new Jogador { Id = 7, Nome = "Éder Militão", Posicao = "Zagueiro", NumeroCamisa = 3, Time = "Real Madrid", DataNascimento = new DateTime(1998, 1, 18), Peso = 78, Altura = 1.86 },
                new Jogador { Id = 8, Nome = "Bruno Guimarães", Posicao = "Meio-campo", NumeroCamisa = 39, Time = "Newcastle", DataNascimento = new DateTime(1997, 11, 16), Peso = 74, Altura = 1.82 },
                new Jogador { Id = 9, Nome = "Raphinha", Posicao = "Atacante", NumeroCamisa = 11, Time = "Barcelona", DataNascimento = new DateTime(1996, 12, 14), Peso = 68, Altura = 1.76 },
                new Jogador { Id = 10, Nome = "Danilo", Posicao = "Lateral", NumeroCamisa = 6, Time = "Juventus", DataNascimento = new DateTime(1991, 7, 15), Peso = 78, Altura = 1.84 }
            );
        }
    }
}