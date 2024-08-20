using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IService _service;
        public ServiceController(IService service) 
        {
            _service=service;
        }

        [HttpGet("GetAllServices")]
        public IActionResult GetAllServices()
        {
            var values = _service.GetAllServices();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }
    }
}
