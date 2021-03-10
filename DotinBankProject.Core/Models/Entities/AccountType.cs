using System.Collections.Generic;
using DotinBankProject.Domain.Models.Entities.Base;

namespace DotinBankProject.Domain.Models.Entities
{
    public class AccountType:Entity
    {
        public AccountType()
        {
            #region Constructor
            Accounts = new HashSet<Account>();
            #endregion
        }
        #region Properties
        public string Name { get; set; }
        #endregion
        #region RelationShips
        public virtual ICollection<Account> Accounts { get; set; }
        #endregion
    }
}
