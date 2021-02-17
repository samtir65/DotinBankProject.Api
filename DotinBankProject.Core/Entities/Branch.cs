using System.Collections.Generic;
using DotinBankProject.Core.Entities.Base;
using DotinSampleProject.Core.Entities.Base;

namespace DotinBankProject.Core.Entities
{
    public class Branch: Entity
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
