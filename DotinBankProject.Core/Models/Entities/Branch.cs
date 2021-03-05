using System.Collections.Generic;
using DotinBankProject.Domain.Models.Entities.Base;

namespace DotinBankProject.Domain.Models.Entities
{
    public class Branch: TEntity
    {
        public Branch()
        {
            #region Generated Constructor
            Users = new HashSet<User>();
            #endregion
        }
        #region Properties
        public string BranchName { get; set; }
        public string Address { get; set; }
        #endregion

        #region Relationships
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<AccountingDocument> AccountingDocuments { get; set; }

        #endregion

    }
}
