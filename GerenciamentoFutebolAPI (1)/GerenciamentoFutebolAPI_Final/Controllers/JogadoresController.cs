using Microsoft.AspNetCore.Mvc;
using GerenciamentoFutebolAPI.Data;
using GerenciamentoFutebolAPI.Models;
using System.Linq;

namespace GerenciamentoFutebolAPI.Controllers
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
        public IActionResult Get() => Ok(_context.Jogadores.ToList());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var jogador = _context.Jogadores.Find(id);
            return jogador == null ? NotFound() : Ok(jogador);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = jogador.Id }, jogador);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var jogador = _context.Jogadores.Find(id);
            if (jogador == null) return NotFound();

            _context.Jogadores.Remove(jogador);
            _context.SaveChanges();
            return NoContent();
        }
    }
}