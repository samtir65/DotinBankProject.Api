using System;
using DotinBankProject.Application.Validators;


namespace DotinBankProject.Application.Models
{
    //[Validator(typeof(AccountModelValidator))]
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
