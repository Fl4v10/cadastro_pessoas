using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonRegister.Domain.Repositories;
using PersonRegister.Impl.Context;
using PersonRegister.Impl.Repositories;

namespace PersonRegister
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<PersonDataContext>(GetConnectionString());

            services.AddScoped<IAddressRepository, AddressRepositoryImpl>();
            services.AddScoped<IPersonRepository, PersonRepositoryImpl>();
        }

        private Action<DbContextOptionsBuilder> GetConnectionString()
        {
            return options =>
                options.UseSqlServer(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
