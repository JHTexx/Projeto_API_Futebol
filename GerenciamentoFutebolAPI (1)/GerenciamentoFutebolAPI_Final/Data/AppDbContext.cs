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
                new Jogador { Id = 1, Nome = "Vinicius Junior", Posicao = "Atacante", NumeroCamisa = 7, Time = "Real Madrid", DataNascimento = new DateTime(2000, 7, 12) },
                new Jogador { Id = 2, Nome = "Rodrygo", Posicao = "Atacante", NumeroCamisa = 11, Time = "Real Madrid", DataNascimento = new DateTime(2001, 1, 9) },
                new Jogador { Id = 3, Nome = "Endrick", Posicao = "Atacante", NumeroCamisa = 19, Time = "Real Madrid", DataNascimento = new DateTime(2006, 7, 21) },
                new Jogador { Id = 4, Nome = "Neymar", Posicao = "Atacante", NumeroCamisa = 10, Time = "Santos", DataNascimento = new DateTime(1992, 2, 5) }
            );
        }
    }
}