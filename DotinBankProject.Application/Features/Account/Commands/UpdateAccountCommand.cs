using System;
using DotinBankProject.Application.Models;
using MediatR;

namespace DotinBankProject.Application.Features.Account.Commands
{
    public class UpdateAccountCommand:IRequest<AccountModel>
    {
        public string AccountNumber { get; set; }
        public string Sheba { get; set; }
        public int AccountsTypeId { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal Amount { get; set; }

    }
}
