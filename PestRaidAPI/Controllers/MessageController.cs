using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("GetAllMessages")]
        public IActionResult GetAllMessages()
        {
            var values = _messageService.GetAllMessages();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }

        [HttpPost("AddMessage")]
        public IActionResult AddMessage(Message message)
        {
            var result = _messageService.AddMessage(message);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpPost("UpdateMessage")]
        public IActionResult UpdateMessage(Message message)
        {
            var result = _messageService.UpdateMessage(message);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var result = _messageService.Get(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}
