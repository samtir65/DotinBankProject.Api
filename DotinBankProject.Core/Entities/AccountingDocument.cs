using System;
using DotinBankProject.Core.Entities.Base;
using DotinBankProject.Core.Entities.Enums;

namespace DotinBankProject.Core.Entities
{
    public class AccountingDocument : Entity
    {
        public AccountingDocument()
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

        #region RelationShips
        public virtual Customer Customers { get; set; }
        public virtual Branch Branch { get; set; }
        #endregion
    }
}
