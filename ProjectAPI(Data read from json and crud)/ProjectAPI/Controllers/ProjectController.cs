using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Xml.Linq;

namespace ProjectAPI.Controllers
{
    [Route("api/v1/project")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private List<Projects> projects;
        public ProjectController()
        {
            string data = System.IO.File.ReadAllText("projects.json");
            JToken obj = JObject.Parse(data);
            obj = obj["projects"];
            projects = JsonConvert.DeserializeObject<List<Projects>>(obj.ToString());
        }            
        
        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<List<Projects>>> GetAll()
        {                
            return Ok(projects);
        }

        [HttpPost]
        [Route("addProject")]
        public async Task<ActionResult<List<Projects>>> AddProject(Projects project)
        {
            projects.Add(project);
            return Ok(projects);
        }

        [HttpPut]
        [Route("updateProject")]
        public async Task<ActionResult<List<Projects>>> UpdateProject(Projects project)
        {
            var proj = projects.Find(p => p.Id == project.Id);
            if(proj == null)
            {
                return BadRequest("Project not found");
            }
            proj.Name = project.Name;

            return Ok(projects);
        }

        [HttpDelete]
        [Route("deleteProject")]
        public async Task<ActionResult<List<Projects>>> DeleteProject(int id)
        {
            var proj = projects.Find(p => p.Id == id);
            if (proj == null)
            {
                return BadRequest("Project not found");
            }

            projects.Remove(proj);

            return Ok(projects);
        }
    }
}
