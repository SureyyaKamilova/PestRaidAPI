using Business.Abstract;
using Entities.Concrete;
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

        [HttpPost("AddAbout")]
        public IActionResult AddAbout(About about)
        {
            var result = _aboutService.AddAbout(about);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest();
        }

        [HttpPost("UpdateAbout")]
        public IActionResult UpdateAbout(About about)
        {
            var result = _aboutService.UpdateAbout(about);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //[HttpDelete("DeleteAbout")]
        //public IActionResult DeleteAbout(int id) 
        //{
        //    var about = _aboutService.Get(id);
        //    if (about.Data == null)
        //    {
        //        return NotFound("Record not found.");
        //    }

        //    var result = _aboutService.DeleteAbout(about.Data);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result.Message);
        //}

        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var result = _aboutService.Get(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

    }
}
