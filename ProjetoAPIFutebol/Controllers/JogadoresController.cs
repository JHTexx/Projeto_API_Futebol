using Microsoft.AspNetCore.Mvc;
using ProjetoAPIFutebol.Data;
using ProjetoAPIFutebol.Models;
using System.Linq;

namespace ProjetoAPIFutebol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public JogadoresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Jogadores.ToList());
            }
            catch
            {
                return StatusCode(500, "Erro ao recuperar os jogadores.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var jogador = _context.Jogadores.Find(id);
                return jogador == null ? NotFound() : Ok(jogador);
            }
            catch
            {
                return StatusCode(500, "Erro ao recuperar o jogador.");
            }
        }

        [HttpGet("buscar")]
        public IActionResult BuscarPorNome([FromQuery] string nome)
        {
            try
            {
                var jogadores = _context.Jogadores
                    .Where(j => j.Nome.Contains(nome))
                    .ToList();
                return Ok(jogadores);
            }
            catch
            {
                return StatusCode(500, "Erro na busca por nome.");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Jogador novoJogador)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _context.Jogadores.Add(novoJogador);
                _context.SaveChanges();
                return CreatedAtAction(nameof(Get), new { id = novoJogador.Id }, novoJogador);
            }
            catch
            {
                return StatusCode(500, "Erro ao cadastrar jogador.");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Jogador jogador)
        {
            if (id != jogador.Id)
                return BadRequest("ID do jogador não corresponde.");

            var jogadorExistente = _context.Jogadores.Find(id);
            if (jogadorExistente == null)
                return NotFound();

            try
            {
                _context.Entry(jogadorExistente).CurrentValues.SetValues(jogador);
                _context.SaveChanges();
                return NoContent();
            }
            catch
            {
                return StatusCode(500, "Erro ao atualizar jogador.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var jogador = _context.Jogadores.Find(id);
            if (jogador == null) return NotFound();

            try
            {
                _context.Jogadores.Remove(jogador);
                _context.SaveChanges();
                return NoContent();
            }
            catch
            {
                return StatusCode(500, "Erro ao excluir jogador.");
            }
        }
    }
}
