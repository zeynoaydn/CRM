using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ICitiesService _citiesService;
        public CitiesController(ICitiesService citiesService)
        {
            _citiesService= citiesService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_citiesService.GetAll();
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
