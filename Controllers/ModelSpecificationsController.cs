using dotnetapitesla.Interfaces;
using dotnetapitesla.Models;
using dotnetapitesla.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnetapitesla.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModelSpecificationsController : ControllerBase
    {
        private readonly IModelSpecifications _modelSpecifications;

        public ModelSpecificationsController(IModelSpecifications modelSpecificationsService)
        {
            _modelSpecifications = modelSpecificationsService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelSpecification>>> GetSpecifications()
        {

            var models = await _modelSpecifications.GetModelSpecifications();
            return Ok(models);


        }
    }
}
