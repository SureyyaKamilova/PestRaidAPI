using Business.Abstract;
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
    }
}
