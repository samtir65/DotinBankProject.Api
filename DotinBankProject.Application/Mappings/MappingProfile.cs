using AutoMapper;
using DotinBankProject.Application.Models.Dtos;
using DotinBankProject.Application.Models.Parameters;
using DotinBankProject.Domain.Models.Entities;

namespace DotinBankProject.Application.Mappings
{
    public class MappingProfile : Profile
    {
      
        #region Constructor
        public MappingProfile()
        {
            CustomerController();
            AccountController();
            UserController();
        }
        #endregion

        #region Method

        private void CustomerController()
        {
            #region Parameters
            CreateMap<CustomerModel, Customer>().ReverseMap();

            CreateMap<CustomerModel, RealCustomer>()
               .ReverseMap();

            CreateMap<CustomerModel, LegalCustomer>()
                .ReverseMap();
            #endregion
            #region Dtos
            CreateMap<CustomerModel, CustomerModelDto>();
            #endregion
        }

        private void AccountController()
        {
            #region parameter

            #endregion

            #region Dtos
            CreateMap<Account, AccountDto>().ReverseMap();
            #endregion
        }
        private void UserController()
        {
            #region parameter

            #endregion

            #region Dtos
            CreateMap<User, UserDto>().ReverseMap();
            #endregion
        }
        #endregion
    }
}
