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
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;
        private IPessoaNegocio _pessoaNegocio;

        public PessoaController(ILogger<PessoaController> logger, IPessoaNegocio pessoaNegocio)
        {
            _logger = logger;
            _pessoaNegocio = pessoaNegocio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pessoaNegocio.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var pessoa = _pessoaNegocio.FindByID(id);

            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Pessoa pessoa)
        {         

            if (pessoa == null)
                return BadRequest();

            return Ok(_pessoaNegocio.Create(pessoa));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Pessoa pessoa)
        {

            if (pessoa == null)
                return BadRequest();

            return Ok(_pessoaNegocio.Update(pessoa));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _pessoaNegocio.Delete(id);

            return NoContent();
        }
    }
}
