using System.Collections.Generic;
using DotinBankProject.Core.Entities.Base;

namespace DotinBankProject.Core.Entities
{
    public class Role: Entity
    {
        public Role()
        {
            #region Constructor
            Users = new HashSet<User>();
            #endregion
        }

        #region Properties
        public string Title { get; set; }

        public bool IsActive { get; set; }

        public string IsDeleted { get; set; }

        #endregion

        #region Relationships
        public virtual ICollection<User> Users { get; set; }

        #endregion

    }
}
