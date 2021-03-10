using DotinBankProject.Domain.Models.Entities.Base;

namespace DotinBankProject.Domain.Models.Entities
{
    public class CustomersAccount:Entity
    {
        
        public CustomersAccount()
        {
            #region Constructor
            #endregion

        }

        #region Properties
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        
        #endregion

        #region Relationships
        public virtual Customer Customers { get; set; }
        public virtual Account Accounts { get; set; }
        #endregion


    }
}
