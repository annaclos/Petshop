using Microsoft.AspNetCore.Mvc;
using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesRepository _clientesService;

        public ClientesController(IClientesRepository clientes)
        {
            _clientesService = clientes;

        }

        [HttpPost]
        public ActionResult Create([FromBody] Clientes clientes)
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
        public ActionResult Get([FromRoute] int id)
        {
            try
            {
                _clientesService.Get(id);
                return Ok(_clientesService.Get(id));

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult List()
        {
            try
            {
                return Ok(_clientesService.List());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] Clientes clientes)
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
