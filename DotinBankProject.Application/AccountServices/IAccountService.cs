using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotinBankProject.Application.Models;

namespace DotinBankProject.Application.AccountServices
{
    public interface IAccountService
    {
        Task<AccountModel> GetAccountAsync(int id);

    }
}
