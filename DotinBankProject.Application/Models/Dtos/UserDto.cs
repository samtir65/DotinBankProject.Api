namespace DotinBankProject.Core.Entities
{
    public class UserDto
    {
        
        #region Properties
        public int RoleId { get; set; }
        public int BranchCode { get; set; }
        public string Email { get; set; }

        public string UserName { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        #endregion

    }
}
