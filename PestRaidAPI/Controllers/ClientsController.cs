using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientsService _clientService;
        public ClientsController(IClientsService clientService)
        {
            _clientService = clientService;
        }
        [HttpGet("GetAllClients")]
        public IActionResult GetAllClients()
        {
            var values = _clientService.GetAllClients();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }

        [HttpPost("AddClient")]
        public IActionResult AddClient(Client client)
        {
            var result = _clientService.AddClient(client);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpPost("UpdateClient")]
        public IActionResult UpdateClient(Client client)
        {
            var result = _clientService.UpdateClient(client);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetClient")]
        public IActionResult GetClient(int id)
        {
            var result = _clientService.Get(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}
