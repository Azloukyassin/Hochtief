using Castle.Core.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp
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
            services.AddScoped<IRepostory<SourceCompany>, SourceCompanyDBRepostory>();
            //services.AddScoped<IRepostory<Labour>, LabourDBRepostory>();
            services.AddScoped<IRepostory<SourceRole>, SourceRoleDBRepostory>();
            //services.AddScoped<IRepostory<SourceStaff>, SourceStaffDBRepostory>();
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
}