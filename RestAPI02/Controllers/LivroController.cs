using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestAPI02.Models;
using RestAPI02.Negocio;

namespace RestAPI02.Controllers
{
    // Versionando a API
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LivroController : Controller
    {
        private readonly ILogger<LivroController> _logger;
        private ILivroNegocio _livroNegocio;

        public LivroController(ILogger<LivroController> logger, ILivroNegocio livroNegocio)
        {
            _logger = logger;
            _livroNegocio = livroNegocio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_livroNegocio.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var livro = _livroNegocio.FindByID(id);

            if (livro == null)
                return NotFound();

            return Ok(livro);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Livro livro)
        {

            if (livro == null)
                return BadRequest();

            return Ok(_livroNegocio.Create(livro));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Livro livro)
        {

            if (livro == null)
                return BadRequest();

            return Ok(_livroNegocio.Update(livro));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _livroNegocio.Delete(id);

            return NoContent();
        }
    }
}
