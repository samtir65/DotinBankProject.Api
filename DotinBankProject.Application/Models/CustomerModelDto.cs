using DotinBankProject.Core.Entities.Base;
using DotinBankProject.Core.Entities.Enums;
using System;

namespace DotinBankProject.Application.Models
{
    public class CustomerModelDto
    {
        public CustomerType CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalCode { get; set; }
        public string CompanyNumber { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }

       

    }
}