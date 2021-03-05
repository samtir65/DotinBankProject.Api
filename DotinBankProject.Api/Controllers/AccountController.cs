using AutoMapper;
using DotinBankProject.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using DotinBankProject.Application.Models.Dtos;
using DotinBankProject.Application.Models.Parameters;
using DotinBankProject.Domain.Models.Entities;
using DotinBankProject.Domain.Repositories.Base;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IRepository<Account> _repositoryAccount;
        private IMapper _mapper;
        public AccountController(IRepository<Account> repositoryAccount,IMapper mapper)
        {
            _repositoryAccount = repositoryAccount;
             _mapper = mapper;
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerModel, RealCustomer>().ReverseMap();
                
            }));
        }
        // GET: api/<AccountController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Account> accounts = _repositoryAccount.GetAll();

            AccountDto accountDto = _mapper.Map<AccountDto>(accounts);
            
            return Ok(accountDto);
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Account account = _repositoryAccount.Get(id);
            if (account == null)
            {
                return NotFound("The account record couldn't be found.");

            }
            var res = JsonSerializer.Serialize(account, null);

            return Ok(res);
        }

        // POST api/<AccountController>
        [HttpPost]
        public IActionResult Post([FromBody] Account account)
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
        public IActionResult Put(int id, [FromBody] Account account)
        {
            if (account == null)
            {
                return BadRequest("account is null");
            }
            Account accounttoUpdate = _repositoryAccount.Get(id);
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
            Account account = _repositoryAccount.Get(id);
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
