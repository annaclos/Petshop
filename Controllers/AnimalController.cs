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
        public ActionResult Create([FromBody] Animal animais)
        {
            try
            {
                _animalService.Create(animais);
                return Ok("Animal criado com sucesso");
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
                return Ok(_animalService.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute]int id)
        {
            try
            {
                return Ok(_animalService.Get(id));

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
                return Ok(_animalService.List());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] Animal animais)
        {
            try
            {
                _animalService.Update(id, animais);
                return Ok("animal atualizado com sucesso");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }

}
