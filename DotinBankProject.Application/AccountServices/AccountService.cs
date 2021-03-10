using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DotinBankProject.Application.Models;
using DotinBankProject.Domain.Models.Entities;
using DotinBankProject.Domain.Repositories.Base;

namespace DotinBankProject.Application.AccountServices
{
    class AccountService
    {
        private readonly IRepository<Account> _repositoryAccount;
        private readonly IMapper _mapper;
       

        public AccountService(IRepository<Account> repositoryAccount, IMapper mapper)
        {
            _repositoryAccount = repositoryAccount;
            _mapper = mapper;
        }

        public async Task<AccountModel> GetAllAccountAsync(int id)
        {
            if (id<=0 )
            {
                throw  new ApplicationException("Account Id Should not be 0 or lower....");
            }
            var accountResult=  await _repositoryAccount.GetAsync(id);
            return _mapper.Map<AccountModel>(accountResult); 
        }
    }


}
