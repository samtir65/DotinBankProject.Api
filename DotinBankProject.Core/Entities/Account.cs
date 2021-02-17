using System;
using System.Collections.Generic;
using DotinBankProject.Core.Entities.Base;

namespace DotinBankProject.Core.Entities
{
    public class Account:Entity
    {
        public Account()
        {
            #region Constructor
            CustomersAccounts = new HashSet<CustomersAccount>();
            #endregion
        }
      
        #region Properties
        public string AccountNumber { get; set; }
        public string Sheba { get; set; }
        public int AccountsTypeId { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal Amount { get; set; }
        #endregion

        #region Relationships
        public virtual AccountType AccountType { get; set; }
        public ICollection<CustomersAccount> CustomersAccounts { get; set; }
        #endregion

    }
}
