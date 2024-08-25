using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceAboutController : ControllerBase
    {
        private readonly IServiceAbout _serviceAbout;
        public ServiceAboutController(IServiceAbout serviceAbout)
        {
            _serviceAbout = serviceAbout;
        }

        [HttpGet("GetAllServiceAbouts")]
        public IActionResult GetAllServiceAbouts() 
        {
            var values = _serviceAbout.GetAllServiceAbouts();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }

        [HttpPost("AddServiceAbout")]
        public IActionResult AddServiceAbout(ServiceAbout serviceAbout)
        {
            var result = _serviceAbout.AddServiceAbout(serviceAbout);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }

        [HttpPost("UpdateServiceAbout")]
        public IActionResult UpdateServiceAbout(ServiceAbout serviceAbout)
        {
            var result = _serviceAbout.UpdateServiceAbout(serviceAbout);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetServiceAbout")]
        public IActionResult GetServiceAbout(int id)
        {
            var result = _serviceAbout.Get(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
                return BadRequest(result.Message);
        }
    }
}
