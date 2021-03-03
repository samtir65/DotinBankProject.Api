using DotinBankProject.Core.Entities;
using DotinBankProject.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IRepository<AccountDto> _repositoryAccount;
        public AccountController(IRepository<AccountDto> repositoryAccount)
        {
            _repositoryAccount = repositoryAccount;
        }
        // GET: api/<AccountController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<AccountDto> role = _repositoryAccount.GetAll();
            return Ok(role);
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            AccountDto account = _repositoryAccount.Get(id);
            if (account == null)
            {
                return NotFound("The account record couldn't be found.");

            }
            var res = JsonSerializer.Serialize(account, null);

            return Ok(res);
        }

        // POST api/<AccountController>
        [HttpPost]
        public IActionResult Post([FromBody] AccountDto account)
        {
            if (account == null)
            {
                return BadRequest("account is Null");
            }
            _repositoryAccount.Add(account);
            return Ok();
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AccountDto account)
        {
            if (account == null)
            {
                return BadRequest("account is null");
            }
            AccountDto accounttoUpdate = _repositoryAccount.Get(id);
            if (accounttoUpdate == null)
            {
                return NotFound("accounttoUpdate could not be found");

            }
            _repositoryAccount.Save();
            return NoContent();

        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AccountDto account = _repositoryAccount.Get(id);
            if (account == null)
            {
                return NotFound();
            }
            _repositoryAccount.Remove(account);
            _repositoryAccount.Save();
            return NoContent();

        }
    }
}
