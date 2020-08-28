using System;
using AuthSystem.Areas.Identity.Data;
using AuthSystem.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AuthSystem.Areas.Identity.IdentityHostingStartup))]
namespace AuthSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthSystemDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthSystemDbContextConnection")));

                services.AddDefaultIdentity<AuthSystemUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AuthSystemDbContext>();
            });
        }
    }
}