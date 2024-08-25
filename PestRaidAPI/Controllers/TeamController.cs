using Autofac.Core;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("GetAllTeams")]
        public IActionResult GetAllTeams()
        {
            var values = _teamService.GetAllTeams();
            if (values.Success)
                return Ok(values);
            return NotFound("Error");
        }

        [HttpGet("GetTeam")]
        public IActionResult GetById(int id)
        {
            var result = _teamService.Get(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpPost("AddTeam")]
        public IActionResult AddTeam(Team team)
        {
            var value = _teamService.AddTeam(team);
            if (value.Success)
            {
                return Ok(value);
            }
            else return BadRequest("Not Addedd!");
        }

        [HttpPost("UpdateTeam")]
        public IActionResult UpdateTeam(Team team)
        {
            var result = _teamService.UpdateTeam(team);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
