////using Microsoft.AspNetCore.Mvc;
////using System.Collections.Generic;
////using DotinBankProject.Domain.Models.Entities;
////using DotinBankProject.Domain.Repositories.Base;

////// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

////namespace DotinBankProject.Api.Controllers
////{
////    [Route("api/[controller]")]
////    [ApiController]
////    public class AccountTypeController : ControllerBase
////    {
////        private readonly IRepository<AccountType> _repositoryAccountType;
////        public AccountTypeController(IRepository<AccountType> repositoryAccountType)
////        {
////            _repositoryAccountType = repositoryAccountType;
////        }
////        // GET: api/<AccountTypeController>
////        [HttpGet]
////        public IActionResult Get()
////        {
////            IEnumerable<AccountType> accountTypes = _repositoryAccountType.GetAll();
////            return Ok(accountTypes);
////        }

////        // GET api/<AccountTypeController>/5
////        [HttpGet("{id}")]
////        public IActionResult Get(int id)
////        {
////            AccountType accountType = _repositoryAccountType.Get(id);
////            if (accountType == null)
////            {
////                return NotFound("The accounttype record couldn't be found.");

////            }
////            return Ok(accountType);
////        }

       
        
////    }
////}
