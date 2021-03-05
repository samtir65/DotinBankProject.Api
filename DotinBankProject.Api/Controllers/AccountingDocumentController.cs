using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotinBankProject.Domain.Models.Entities;
using DotinBankProject.Domain.Repositories.Base;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingDocumentController : ControllerBase
    {
        private readonly IRepository<AccountingDocument> _repositoryAccountingDocument;
        public AccountingDocumentController(IRepository<AccountingDocument> repositoryAccountingDocument)
        {
            _repositoryAccountingDocument = repositoryAccountingDocument;
        }
        // GET: api/<AccountingDocumentController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<AccountingDocument> accountingDocuments = _repositoryAccountingDocument.GetAll();
            return Ok(accountingDocuments);
        }

        // GET api/<AccountingDocumentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            AccountingDocument accountingDocument = _repositoryAccountingDocument.Get(id);
            if (accountingDocument == null)
            {
                return NotFound("The accountingDocument record couldn't be found.");

            }
            return Ok(accountingDocument);
        }

        // POST api/<AccountingDocumentController>
        [HttpPost]
        public IActionResult Post([FromBody] AccountingDocument accountingDocument)
        {
            if (accountingDocument == null)
            {
                return BadRequest("accountingDocument is Null");
            }
            _repositoryAccountingDocument.Add(accountingDocument);
            return Ok();
        }

        // PUT api/<AccountingDocumentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AccountingDocument accountingDocument)
        {
            if (accountingDocument == null)
            {
                return BadRequest("accountingDocument is null");
            }
            AccountingDocument accountingDocumentUpdate = _repositoryAccountingDocument.Get(id);
            if (accountingDocumentUpdate == null)
            {
                return NotFound("role accountingDocumentUpdate not be found");

            }
            _repositoryAccountingDocument.Save();
            return NoContent();

        }

        // DELETE api/<AccountingDocumentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AccountingDocument accountingDocument = _repositoryAccountingDocument.Get(id);
            if (accountingDocument == null)
            {
                return NotFound();
            }
            _repositoryAccountingDocument.Remove(accountingDocument);
            _repositoryAccountingDocument.Save();
            return NoContent();

        }
    }
}
