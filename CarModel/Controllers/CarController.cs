using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private List<string> models = new List<string> { "Dacia", "Volkswagen", "Fiat", "Renault" };
        [HttpGet]

        public ActionResult GetModels()
        {
 
            if (models.Count == 0)
                return NotFound();
            return Ok(models);
        }
        [HttpPost]
        public ActionResult CreatNewModels(string newModel)
        {
            if (string.IsNullOrWhiteSpace(newModel))
                return BadRequest("Invalid model name");
            models.Add(newModel);
            return CreatedAtAction(nameof(GetModels), models);
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteModels(string id)
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();
            return NoContent();
        }
    }
}
