using DotinBankProject.Core.Entities.Base;

namespace DotinBankProject.Core.Entities
{
    public class User: Entity
    {
        public User()
        {
            #region Constructor
            #endregion
        }

        #region Properties
        public int RoleId { get; set; }
        public int BranchCode { get; set; }
        public string Email { get; set; }

        public string UserName { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        #endregion

        #region Relationships
        public virtual Role Role { get; set; }
        public virtual Branch Branch { get; set; }          

        #endregion

    }
}
