using AutoMapper;
using DotinBankProject.Application.Models;
using DotinBankProject.Core.Entities;

namespace DotinBankProject.Application.Mappings
{
    public class MapperConfiguration : Profile
    {
        #region Constructor
        public MapperConfiguration()
        {

            CustomerController();

        }
        #endregion

        #region Method

        private void CustomerController()
        {

            #region Parameters
            CreateMap<CustomerModel, Customer>().ReverseMap();

            CreateMap<CustomerModel, RealCustomer>()
                .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.FatherName, opts => opts.MapFrom(src => src.FatherName))
                .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.LastName))
                .ForMember(dest => dest.NationalCode, opts => opts.MapFrom(src => src.NationalCode)).ReverseMap();

            CreateMap<CustomerModel, LegalCustomer>()
                .ForMember(dest => dest.CompanyName, opts => opts.MapFrom(src => src.CompanyName))
                .ForMember(dest => dest.CompanyNumber, opts => opts.MapFrom(src => src.CompanyNumber)).ReverseMap();
            #endregion
            #region Dtos
            CreateMap<CustomerModel, CustomerModelDto>();
            #endregion
        }
        #endregion
    }
}
//__repository = repository;
//_mapper = new Mapper(new MapperConfiguration(cfg =>
//{
//    cfg.CreateMap<CustomerModel,RealCustomer>().ReverseMap();
//    cfg.CreateMap<LegalCustomer, CustomerModel>().ReverseMap();
//    cfg.CreateMap<Customer, CustomerModel>().ReverseMap();
//}));