using System;

namespace DotinBankProject.Core.Entities
{
    public  class LegalCustomer:Customer
    {
        public LegalCustomer(string companyNumber,string companyName)
        {
           
            companyNumber = CompanyNumber;
            companyName = CompanyName;
        }
        #region Properties
        public string CompanyNumber { get; set; }
        public string CompanyName { get; set; }

        public override bool HasDiscriminator(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
