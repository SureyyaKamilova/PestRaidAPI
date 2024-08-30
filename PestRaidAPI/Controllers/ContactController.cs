using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("GetAllContacts")]
        public IActionResult GetAllContacts()
        {
            var values = _contactService.GetAllContacts();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }

        [HttpPost("AddContact")]
        public IActionResult AddContact(Contact contact)
        {
            var result = _contactService.AddContact(contact);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }

        [HttpPost("UpdateContact")]
        public IActionResult UpdateContact(Contact contact)
        {
            var result = _contactService.UpdateContact(contact);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var result = _contactService.Get(id);

            if (result != null)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}
