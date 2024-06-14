using Microsoft.AspNetCore.Mvc;
using Petshop.Model.Data;
using Petshop.src.Contracts.Repository;
using Petshop.src.Contracts.Service;

namespace Petshop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Animal animais)
        {
            try
            {
                await _animalService.Create(animais);
                return Ok("Animal criado com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            try
            {
                await _animalService.Delete(id);
                return Ok("animal deletado com sucesso");
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
                var result = await _animalService.Get(id);
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
                var result = await _animalService.List();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromRoute] int id, [FromBody] Animal animais)
        {
            try
            {
                await _animalService.Update(id, animais);
                return Ok("animal atualizado com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
