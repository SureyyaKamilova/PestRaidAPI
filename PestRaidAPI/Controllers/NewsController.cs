using Business.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet("GetAllNews")]
        public IActionResult GetAllNews()
        {
            var values = _newsService.GetAllNews();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }

        [HttpPost("AddNews")]
        public IActionResult AddNews(News news)
        {
            var result = _newsService.AddNews(news);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }

        [HttpPost("UpdateNews")]
        public IActionResult UpdateNews(News news)
        {
            var result = _newsService.UpdateNews(news);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetNews")]
        public IActionResult GetNews(int id)
        {
            var result = _newsService.Get(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
        
    }
}
