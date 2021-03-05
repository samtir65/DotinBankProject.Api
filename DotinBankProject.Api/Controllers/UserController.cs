using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DotinBankProject.Application.Models.Dtos;
using DotinBankProject.Domain.Models.Entities;
using DotinBankProject.Domain.Repositories.Base;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IRepository<User> _repositoryUser;
        private readonly IMapper _mapper;
        public UserController(IRepository<User> repositoryUser, IMapper mapper)
        {
            _repositoryUser = repositoryUser;
            _mapper = mapper;
           
        }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<User> user = _repositoryUser.GetAll();
            var userDto = _mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = _repositoryUser.Get(id);
            if (user == null)
            {
                return NotFound("The User record couldn't be found.");

            }
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("user is Null");
            }
            _repositoryUser.Add(user);
            return Ok();

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("user is null");
            }
            User usertoUpdate = _repositoryUser.Get(id);
            if (usertoUpdate == null)
            {
                return NotFound("user could not be found");

            }
            _repositoryUser.Save();
            return NoContent();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            User user = _repositoryUser.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            _repositoryUser.Remove(user);
            _repositoryUser.Save();
            return NoContent();
        }
    }
}
