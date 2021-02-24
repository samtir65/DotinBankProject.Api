using DotinBankProject.Core.Entities;
using DotinBankProject.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> _repository;
        public CustomerController(IRepository<Customer> repository)
        {
            _repository = repository;

        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
              
            IEnumerable<Customer> customers = _repository.GetAll();
            return Created("temp", customers);
        }
        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Customer customer = _repository.Get(id);
            if (customer == null)
            {
                return NotFound("The Employee record couldn't be found.");

            }
            return Ok(customer);
        }

        //POST api/<CustomerController>
        //[HttpPost]
        //public IActionResult Post([FromBody] LegalCustomer customer)
        //{
        //    if (customer == null)
        //    {
        //        return BadRequest("Customer is Null");
        //    }
        //    _repository.Add(customer);
        //    return Ok(customer);
        //}

        //POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] RealCustomer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer is Null");
            }
            _repository.Add(customer);
            _repository.Save();
            return Ok(customer);
        }
        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer is null");
            }
            Customer customerToUpdate = _repository.Get(id);
            if (customerToUpdate == null)
            {
                return NotFound("Customer could not be found");

            }
            _repository.Save();
            return NoContent();
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            Customer customer = _repository.Get(id);
            if (customer == null)
            {
                return "Customer is not found";
            }
            _repository.Remove(customer);
            _repository.Save();
            return "Customer Deleted";
        }
    }
}
