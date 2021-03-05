using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DotinBankProject.Domain.Models.Entities;
using DotinBankProject.Domain.Repositories.Base;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRepository<Role> _repositoryRole;
        public RoleController(IRepository<Role> repositoryRole)
        {
            _repositoryRole = repositoryRole;
        }
        // GET: api/<RoleController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Role> role = _repositoryRole.GetAll();
            return Ok(role);
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Role role = _repositoryRole.Get(id);
            if (role == null)
            {
                return NotFound("The Role record couldn't be found.");

            }
            return Ok(role);
        }

        // POST api/<RoleController>
        [HttpPost]
        public IActionResult Post([FromBody] Role role)
        {
            if (role == null)
            {
                return BadRequest("role is Null");
            }
            _repositoryRole.Add(role);
            return Ok();
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Role role)
        {
            if (role == null)
            {
                return BadRequest("user is null");
            }
            Role roletoUpdate = _repositoryRole.Get(id);
            if (roletoUpdate == null)
            {
                return NotFound("role could not be found");

            }
            _repositoryRole.Save();
            return NoContent();

        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Role role = _repositoryRole.Get(id);
            if (role == null)
            {
                return NotFound();
            }
            _repositoryRole.Remove(role);
            _repositoryRole.Save();
            return NoContent();

        }
    }
}
