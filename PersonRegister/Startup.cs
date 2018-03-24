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
            services.AddDbContext<PersonDataContext>(GetConnectionString());
            services.AddMvc().AddJsonOptions(
                options => 
                    options.SerializerSettings.ReferenceLoopHandling 
                    = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddTransient<IAddressRepository, AddressRepositoryImpl>();
            services.AddTransient<IPersonRepository, PersonRepositoryImpl>();
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
            app.UseCors("CorsPolicy");
        }
    }
}
