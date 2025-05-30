using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAPIFutebol.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Posicao { get; set; }

        [Range(1, 99)]
        public int NumeroCamisa { get; set; }

        [Required]
        public string Time { get; set; }

        public DateTime DataNascimento { get; set; }

        public float Altura { get; set; }

        public float Peso { get; set; }

        public string Nacionalidade { get; set; }
    }
}
