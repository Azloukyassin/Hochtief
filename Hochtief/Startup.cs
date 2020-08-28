using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hochtief.Models;
using Hochtief.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hochtief
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
           this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddScoped<IRepostory<TestTabelle>, TestDBRepostory>();
            services.AddScoped<IRepostory<SourceCompany>, SourceCompanyDBRepostory>();
           // services.AddScoped<IRepostory<Labour>, LabourDBRepostory>();
            services.AddScoped<IRepostory<SourceRole>, SourceRoleDBRepostory>();
            services.AddScoped<IRepostory<Weather>, WeatherDBRepostory>();
            services.AddScoped<IRepostory<SourceEquipment>, SourceEquipmentDBRepostory>(); 
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddDbContext<TestDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
            );
        }  
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();      
        }
    }
}
