using System;
using System.Threading.Tasks;
using AutoMapper;
using DotinBankProject.Application.Models;
using DotinBankProject.Domain.Models.Entities;
using DotinBankProject.Domain.Repositories.Base;

namespace DotinBankProject.Application.AccountServices
{
    public class AccountService:IAccountService
    {
        private readonly IRepository<Account> _repositoryAccount;
        private readonly IMapper _mapper;
       

        public AccountService(IRepository<Account> repositoryAccount, IMapper mapper)
        {
            _repositoryAccount = repositoryAccount;
            _mapper = mapper;
        }

        public async Task<AccountModel> GetAccountAsync(int id)
        {
            var accountResult=  await _repositoryAccount.GetAsync(id);
            var result = _mapper.Map<AccountModel>(accountResult);
            return result;
        }
    }


}
