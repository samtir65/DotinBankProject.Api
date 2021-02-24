using System.Collections.Generic;
using DotinBankProject.Core.Entities.Base;

namespace DotinBankProject.Core.Entities
{
    public class AccountType:TEntity
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
