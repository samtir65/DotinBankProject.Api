using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using DotinBankProject.Application.Features.Account.Commands;
using DotinBankProject.Application.Models.Dtos;
using DotinBankProject.Domain.Models.Entities;
using DotinBankProject.Domain.Repositories.Base;
using DotinBankProject.Application.Models;
using MediatR;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        //private readonly IRepository<Account> _repositoryAccount;
        //private readonly IMapper _mapper;
        private readonly IMediator _mediator;
       // private readonly ILogger _logger;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
            //_repositoryAccount = repositoryAccount;
           // _logger = logger;
            //_mapper = mapper;
        }
        // GET: api/<AccountController>
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    _logger.LogInformation(null,"",);
        //    var accounts = _repositoryAccount.GetAsync();

        //    var accountDto = _mapper.Map<IEnumerable<AccountDto>>(accounts);

        //    return Ok(accountDto);
        //}

        // GET api/<AccountController>/5
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var account = _repositoryAccount.GetAsync(id);
        //    if (account == null)
        //    {
        //        return NotFound("The account record couldn't be found.");

        //    }

        //    var accountDto = _mapper.Map<AccountDto>(account);


        //    return Ok(accountDto);
        //}

        // POST api/<AccountController>
        //[HttpPost]
        //public IActionResult Post([FromBody] AccountModel account)
        //{
        //    if (account == null)
        //    {
        //        return BadRequest("account is Null");
        //    }

        //    var entity = _mapper.Map<AccountModel>(account);
        //    _repositoryAccount.AddAsync(entity);
        //    return Ok();
        //}

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateAccountCommand command,CancellationToken cancellationToken)
        {
            var response = _mediator.Send(command, cancellationToken);
            if (response == null)
            {
                return BadRequest();
            }

            return Ok(response);
            //if (id != accountModel.Id)
            //{
            //    return BadRequest();
            //}

            //var entiity = _mapper.Map<Account>(accountModel);
            //_repositoryAccount.Update(entiity);
            // _repositoryAccount.Save();

            //return Ok();

        }

        // DELETE api/<AccountController>/5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    Account account = _repositoryAccount.Get(id);
        //    if (account == null)
        //    {
        //        return NotFound();
        //    }
        //    _repositoryAccount.Remove(account);
        //    _repositoryAccount.Save();
        //    return NoContent();

        //}
    }
}
