using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PestRaidAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("GetAllProjects")]
        public IActionResult GetAllProjects()
        {
            var values = _projectService.GetAllProjects();
            if (values.Success)
            {
                return Ok(values);
            }
            return NotFound("Error");
        }

        [HttpPost("AddProject")]
        public IActionResult AddProject(Project project)
        {
            var result = _projectService.AddProject(project);

            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest();
        }
        [HttpPost("UpdateProject")]
        public IActionResult UpdateProject(Project project)
        {
            var result = _projectService.UpdateProject(project);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetProject")]
        public IActionResult GetClient(int id)
        {
            var result = _projectService.Get(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}
