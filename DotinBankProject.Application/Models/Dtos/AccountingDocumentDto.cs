using System;
using DotinBankProject.Domain.Models.Entities.Enums;

namespace DotinBankProject.Application.Models.Dtos
{
    public class AccountingDocumentDto
    {
        public AccountingDocumentDto()
        {
            #region Constructor
           
            #endregion
        }
        #region Properties
        public AccountingDocumentType AccountingDocumentType { get; set; }
        public DateTime Date { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int CustomerId { get; set; }
        public int BranchCode { get; set; }
        #endregion

       
    }
}
