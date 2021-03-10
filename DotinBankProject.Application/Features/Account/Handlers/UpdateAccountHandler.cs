using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DotinBankProject.Application.Features.Account.Commands;
using DotinBankProject.Application.Models;
using DotinBankProject.Domain.Repositories.Base;
using MediatR;

namespace DotinBankProject.Application.Features.Account.Handlers
{
    public class UpdateAccountHandler : IRequestHandler<UpdateAccountCommand, AccountModel>
    {
        private readonly IRepository<Domain.Models.Entities.Account> _repository;
        private readonly IMapper _mapper;
        public UpdateAccountHandler(IRepository<Domain.Models.Entities.Account> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<AccountModel> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Domain.Models.Entities.Account>(request);
            var accuntUpdate = await  _repository.UpdateAsync(entity,cancellationToken);
            var result = _mapper.Map<AccountModel>(accuntUpdate);
            return result;


        }
    }
}
