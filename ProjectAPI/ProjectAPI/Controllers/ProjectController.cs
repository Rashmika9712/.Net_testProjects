using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ProjectAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        string project = System.IO.File.ReadAllText("projects.json");

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<Projects>>> GetAll()
        {
            
            return Ok(project);
        }

        [HttpPost]
        [Route("AddProject")]
        public async Task<ActionResult<List<Projects>>> AddProject(Projects project)
        {
            return Ok(project);
        }

        [HttpPut]
        [Route("UpdateProject")]
        public async Task<ActionResult<List<Projects>>> UpdateProject(Projects project)
        {
            return Ok(project);
        }

        [HttpDelete]
        [Route("DeleteProject/{id}")]
        public async Task<ActionResult<List<Projects>>> DeleteProject(int id)
        {
            return Ok(project);
        }

    }
}
