using DotinBankProject.Core.Entities;
using DotinBankProject.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IRepository<Branch> _repositoryBranch;
        public BranchController(IRepository<Branch> repositoryBranch)
        {
            _repositoryBranch = repositoryBranch;
        }
        // GET: api/<BranchController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Branch> branches = _repositoryBranch.GetAll();
            return Ok(branches);
        }

        // GET api/<BranchController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Branch branch = _repositoryBranch.Get(id);
            if (branch == null)
            {
                return NotFound("The branch record couldn't be found.");

            }
            return Ok(branch);
        }

        // POST api/<BranchController>
        [HttpPost]
        public IActionResult Post([FromBody] Branch branch)
        {
            if (branch == null)
            {
                return BadRequest("branch is Null");
            }
            _repositoryBranch.Add(branch);
            return Ok();
        }

        // PUT api/<BranchController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Branch branch)
        {
            if (branch == null)
            {
                return BadRequest("branch is null");
            }
            Branch branchtoUpdate = _repositoryBranch.Get(id);
            if (branchtoUpdate == null)
            {
                return NotFound("branch could not be found");

            }
            _repositoryBranch.Save();
            return NoContent();

        }

        // DELETE api/<BranchController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Branch branch = _repositoryBranch.Get(id);
            if (branch == null)
            {
                return NotFound();
            }
            _repositoryBranch.Remove(branch);
            _repositoryBranch.Save();
            return NoContent();

        }
    }
}
