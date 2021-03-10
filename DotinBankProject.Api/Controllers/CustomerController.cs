//using AutoMapper;
//using DotinBankProject.Api.ResultModel;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using System.Text.Json;
//using DotinBankProject.Application.Models.Parameters;
//using DotinBankProject.Domain.Models.Entities;
//using DotinBankProject.Domain.Models.Entities.Enums;
//using DotinBankProject.Domain.Repositories.Base;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace DotinBankProject.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CustomerController : ControllerBase
//    {
//        private readonly IRepository<LegalCustomer> _repositoryLegalCustomer;
//        private readonly IRepository<RealCustomer> _repositoryRealCustomer;
//        private readonly IRepository<Customer> _repositoryCustomer;
//        private readonly IMapper _mapper;
//        public CustomerController(IRepository<LegalCustomer> repositoryLegalCustomer
//            , IRepository<RealCustomer> repositoryRealCustomer
//            , IRepository<Customer> repositoryCustomer
//            , IMapper mapper
//             )
//        {
//            _repositoryLegalCustomer = repositoryLegalCustomer;
//            _repositoryRealCustomer = repositoryRealCustomer;
//            _repositoryCustomer = repositoryCustomer;
//            _mapper = mapper;


//        }
//        // GET: api/<CustomerController>
//        [HttpGet]
//        public IActionResult Get()
//        {

//            var customers = new List<CustomerModel>(); ;
//            var legalCustomer = _repositoryLegalCustomer.GetAll();
//            var realCustomer = _repositoryRealCustomer.GetAll();
//            var legalmodel = _mapper.Map<List<CustomerModel>>(legalCustomer);
//            var realmodel = _mapper.Map<List<CustomerModel>>(realCustomer);
//            customers.AddRange(legalmodel);
//            customers.AddRange(realmodel);

//            string CustomerApplication;

    

//            return Ok(customers);

//        }
//        // GET api/<CustomerController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            var result = new ApiResultModel();
//            Customer customer = _repositoryCustomer.Get(id);
//            //if (customer == null)
//            //{
//            //    return NotFound("The Employee record couldn't be found.");

//            //}
//            result.Data = customer;
//            return JsonSerializer.Serialize(result);
//        }

//        //POST api/<CustomerController>
//        [HttpPost]
//        public IActionResult Post(CustomerModel model)
//        {

//            if (model == null)
//            {
//                return BadRequest("Customer is Null");
//            }
//            if (!ModelState.IsValid)
//            {
//                return BadRequest();
//            }

//            if (model.CustomerType == CustomerType.Real)
//            {
//                var entity = _mapper.Map<RealCustomer>(model);
//                _repositoryRealCustomer.Add(entity);
//            }

//            else if (model.CustomerType == CustomerType.Legal)
//            {
//                var entity = _mapper.Map<LegalCustomer>(model);
//                _repositoryLegalCustomer.Add(entity);
//            }
//            _repositoryCustomer.Save();

//            return Ok(model);
//        }
//        // PUT api/<CustomerController>/5
//        [HttpPut("{id}")]
//        public IActionResult Put(int id, [FromBody] Customer customer)
//        {
//            if (customer == null)
//            {
//                return BadRequest("Customer is null");
//            }
//            Customer customerToUpdate = _repositoryCustomer.Get(id);
//            if (customerToUpdate == null)
//            {
//                return NotFound("Customer could not be found");

//            }
//            _repositoryCustomer.Save();
//            return NoContent();
//        }

//        // DELETE api/<CustomerController>/5
//        [HttpDelete("{id}")]
//        public string Delete(int id)
//        {
//            Customer customer = _repositoryCustomer.Get(id);
//            if (customer == null)
//            {
//                return "Customer is not found";
//            }
//            _repositoryCustomer.Remove(customer);
//            _repositoryCustomer.Save();
//            return "Customer Deleted";
//        }
//    }
//}
