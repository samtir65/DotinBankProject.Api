using AutoMapper.Configuration;
using DotinBankProject.Application.Models.Parameters;
using Microsoft.Extensions.DependencyInjection;

namespace DotinBankProject.Application.Healpers
{
    public static class DependencyResolver
    {
        public static void ConfigureApplicationServices(this  IServiceCollection services,IConfiguration configuration)
        {

            // Add AutoMapper
            services.AddAutoMapper(typeof(CustomerModel));
        }
    }
}
