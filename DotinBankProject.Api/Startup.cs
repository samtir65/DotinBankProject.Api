using DotinBankProject.Application.Models;
using DotinBankProject.Core.Entities;
using DotinBankProject.Core.Entities.Base;
using DotinBankProject.Core.Repositories;
using DotinBankProject.Infrastructure.Data;
using DotinBankProject.Infrastructure.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace DotinBankProject.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<DotinBankContext>(builder => { builder.UseSqlServer(Configuration.GetConnectionString("BankConnectionString")); });
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            services.AddScoped<IRepository<RealCustomer>, Repository<RealCustomer>>();
            services.AddScoped<IRepository<LegalCustomer>, Repository<LegalCustomer>>();
            services.AddScoped<IRepository<Customer>, Repository<Customer>>();
            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<IRepository<Role>, Repository<Role>>();
            services.AddScoped<IRepository<AccountDto>, Repository<AccountDto>>();
            services.AddScoped<IRepository<AccountingDocument>, Repository<AccountingDocument>>();
            services.AddScoped<IRepository<AccountType>, Repository<AccountType>>();
            services.AddScoped<IRepository<Branch>, Repository<Branch>>();
            //services.AddScoped<IRepository<CustomerModel>, Repository<CustomerModel>>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DotinBankProject.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DotinBankProject.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
