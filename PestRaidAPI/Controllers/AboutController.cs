using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet("GetAllAbouts")]
        public IActionResult GetAllAbouts()
        {
            var values = _aboutService.GetAllAbouts();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }

    }
}
