using DotinBankProject.Core.Entities.Enums;
using System.Collections.Generic;
using DotinBankProject.Core.Entities.Base;

namespace DotinBankProject.Core.Entities
{
    public class Customer:Entity
    {
       
        public Customer()
        {
            #region Constructor
            AccountingDocuments = new HashSet<AccountingDocument>();
            CustomersAccounts = new HashSet<CustomersAccount>();
            #endregion

        }
       
        #region Properties
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public CustomerType CustomerType { get; set; }
        #endregion

        #region RelationShips
        public virtual ICollection<AccountingDocument> AccountingDocuments { get; set; }
        public virtual ICollection<CustomersAccount> CustomersAccounts { get; set; }
        #endregion

    }
}
