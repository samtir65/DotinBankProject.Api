using AutoMapper;
using DotinBankProject.Application.Models;
using DotinBankProject.Core.Entities;
using DotinBankProject.Core.Entities.Enums;
using DotinBankProject.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotinBankProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<LegalCustomer> _repositoryLegalCustomer;
        private readonly IRepository<RealCustomer> _repositoryRealCustomer;
        private readonly IRepository<CustomerModel> _repository;
        private readonly IRepository<Customer> _repositoryCustomer;
        private readonly IMapper _mapper;
        public CustomerController(IRepository<LegalCustomer> repositoryLegalCustomer
            , IRepository<RealCustomer> repositoryRealCustomer
            , IRepository<Customer> repositoryCustomer
             ,IRepository<CustomerModel> repository)
        {
            _repositoryLegalCustomer = repositoryLegalCustomer;
            _repositoryRealCustomer = repositoryRealCustomer;
            _repositoryCustomer = repositoryCustomer;
            _repository = repository;
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerModel, RealCustomer>().ReverseMap();
                cfg.CreateMap<LegalCustomer, CustomerModel>().ReverseMap();
                cfg.CreateMap<Customer, CustomerModel>().ReverseMap();
               //cfg.CreateMap<CustomerModel, CustomerModelDto>().ReverseMap();
            }));

        }
        // GET: api/<CustomerController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CustomerModel>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
             
            IEnumerable<CustomerModel> customers = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<CustomerModel>>(customers));
            //return Ok(customers);
            
        }
        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Customer customer = _repositoryCustomer.Get(id);
            if (customer == null)
            {
                return NotFound("The Employee record couldn't be found.");

            }
            return Ok(customer);
        }

        //POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post(CustomerModel model)
        {

            if (model == null)
            {
                return BadRequest("Customer is Null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (model.CustomerType == CustomerType.Real)
            {
                var entity = _mapper.Map<RealCustomer>(model);
                 _repositoryRealCustomer.Add(entity);
            }

            else if (model.CustomerType == CustomerType.Legal)
            {
                var entity = _mapper.Map<LegalCustomer>(model);
                 _repositoryLegalCustomer.Add(entity);
            }
                _repositoryCustomer.Save();
            return Ok(model);
        }
        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer is null");
            }
            Customer customerToUpdate = _repositoryCustomer.Get(id);
            if (customerToUpdate == null)
            {
                return NotFound("Customer could not be found");

            }
            _repositoryCustomer.Save();
            return NoContent();
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            Customer customer = _repositoryCustomer.Get(id);
            if (customer == null)
            {
                return "Customer is not found";
            }
            _repositoryCustomer.Remove(customer);
            _repositoryCustomer.Save();
            return "Customer Deleted";
        }
    }
}
