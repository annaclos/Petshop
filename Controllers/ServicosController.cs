using Microsoft.AspNetCore.Mvc;
using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicosController : ControllerBase
    {
        private readonly IServicosService _servicosService;
        public ServicosController(IServicosService servicosService) 
        { 
            _servicosService = servicosService;
        }
        [HttpPost]
        public ActionResult Create([FromBody] Servicos servicos)
        {
            try
            {
                _servicosService.Create(servicos);
                return Ok("Serviço criado com sucesso");
            }
            catch (Exception e) 
            { 
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok(_servicosService.Delete(id));
            }
            catch (Exception e) 
            { 
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                return Ok(_servicosService.Get(id));
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
                return Ok(_servicosService.List());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public ActionResult Update([FromRoute] int id, [FromBody] Servicos servicos)
        {
            try
            {
                _servicosService.Update(id, servicos);
                return Ok("Serviço atualizado com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
