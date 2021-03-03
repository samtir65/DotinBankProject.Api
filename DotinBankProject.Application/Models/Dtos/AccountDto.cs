using System;

namespace DotinBankProject.Application.Models
{
    public class AccountDto
    {
       
        #region Properties
        public string AccountNumber { get; set; }
        public string Sheba { get; set; }
        public int AccountsTypeId { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal Amount { get; set; }
        #endregion

       
    }
}
