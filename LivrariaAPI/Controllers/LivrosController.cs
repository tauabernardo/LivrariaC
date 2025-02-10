using Microsoft.AspNetCore.Mvc;
using LivrariaAPI.Models;
using LivrariaAPI.DTOs;

namespace LivrariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private static List<LivroFisico> _livrosFisicos = new();
        private static List<LivroDigital> _livrosDigitais = new();

        // POST: api/livros/fisico
        [HttpPost("fisico")]
        public IActionResult CriarLivroFisico([FromBody] LivroFisicoDTO livroDto)
        {
            if (livroDto == null)
                return BadRequest("Livro inválido.");

            var livro = new LivroFisico
            {
                Titulo = livroDto.Titulo,
                Autor = livroDto.Autor,
                ISBN = livroDto.ISBN,
                Peso = livroDto.Peso,
                TipoCapa = livroDto.TipoCapa
            };

            _livrosFisicos.Add(livro);
            return Ok(new { message = "Livro físico cadastrado com sucesso!", livro });
        }

        // POST: api/livros/digital
        [HttpPost("digital")]
        public IActionResult CriarLivroDigital([FromBody] LivroDigitalDTO livroDto)
        {
            if (livroDto == null)
                return BadRequest("Livro inválido.");

            var livro = new LivroDigital
            {
                Titulo = livroDto.Titulo,
                Autor = livroDto.Autor,
                ISBN = livroDto.ISBN,
                TamanhoArquivoMB = livroDto.TamanhoArquivoMB,
                Formato = livroDto.Formato
            };

            _livrosDigitais.Add(livro);
            return Ok(new { message = "Livro digital cadastrado com sucesso!", livro });
        }
    }
}
