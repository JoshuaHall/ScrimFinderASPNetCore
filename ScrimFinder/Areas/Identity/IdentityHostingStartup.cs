using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ScrimFinder.Areas.Identity.Data;
using ScrimFinder.Models;

[assembly: HostingStartup(typeof(ScrimFinder.Areas.Identity.IdentityHostingStartup))]
namespace ScrimFinder.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ScrimFinderContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ScrimFinderContextConnection")));

                services.AddDefaultIdentity<ScrimFinderUser>(config =>
                {
                    config.SignIn.RequireConfirmedEmail = true;
                })
                .AddEntityFrameworkStores<ScrimFinderContext>();
            });
        }
    }
}