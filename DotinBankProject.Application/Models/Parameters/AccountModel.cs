using System;

namespace DotinBankProject.Application.Models
{
    public class AccountModel
    {
       
        #region Properties
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string Sheba { get; set; }
        public int AccountsTypeId { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal Amount { get; set; }
        #endregion

       
    }
}
