using Microsoft.AspNetCore.Mvc;
using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clientesService;

        public ClienteController(IClienteRepository clientes)
        {
            _clientesService = clientes;

        }

        [HttpPost]
        public ActionResult Create([FromBody] Cliente clientes)
        {
            try
            {
                _clientesService.Create(clientes);
                return Ok("Cliente criado com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            try
            {
                _clientesService.Delete(id);
                return Ok("Cliente deletado com sucesso!");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get([FromRoute] int id)
        {
            try
            {
                var result = await _clientesService.Get(id);
                return Ok(result);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public async Task<ActionResult> List()
        {
            try
            {
                var result = await _clientesService.List();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] Cliente clientes)
        {
            try
            {
                _clientesService.Update(id, clientes);
                    return Ok("Cliente atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
