using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private IPartnerService _partnerService;
        public PartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpGet("GetAllPartners")]
        public IActionResult GetAllPartners()
        {
            var values = _partnerService.GetAllPartners();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }

        [HttpPost("AddPartner")]
        public IActionResult AddProduct(Partner partner)
        {
            var result = _partnerService.AddPartner(partner);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
    }
}
