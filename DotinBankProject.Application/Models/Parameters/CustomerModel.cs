using DotinBankProject.Domain.Models.Entities.Enums;

namespace DotinBankProject.Application.Models.Parameters
{
    public class CustomerModel
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

        //public object ToEntity()
        //{
        //    throw new NotImplementedException();
        //}

        //public object ToEntity<T>()
        //{
            
        //}
        //internal object ToEntity<T>()
        //{
        //    throw new NotImplementedException();
        //}


    }
}