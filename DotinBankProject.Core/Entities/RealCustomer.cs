using System;

namespace DotinBankProject.Core.Entities
{
    public class RealCustomer:Customer
    {
        public RealCustomer(string firstName,string lastName,string fatherName,string nationalCode)
        {
            firstName = FirstName;
            lastName = LastName;
            firstName = FirstName;
            nationalCode = NationalCode;
             

        }
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalCode { get; set; }

        public override bool HasDiscriminator(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
