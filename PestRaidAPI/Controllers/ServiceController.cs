using Business.Abstract;
using Entities.Concrete;
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

        [HttpPost("AddService")]
        public IActionResult AddService(Service service)
        {
            var result = _service.AddService(service);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }

        [HttpPost("UpdateService")]
        public IActionResult UpdateService(Service service)
        {
            var result = _service.UpdateService(service);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetServiceAbout")]
        public IActionResult GetService(int id)
        {
            var result = _service.Get(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest(result.Message);
        }
    }
}
