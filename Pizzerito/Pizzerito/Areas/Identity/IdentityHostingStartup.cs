﻿using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Pizzerito.Areas.Identity.IdentityHostingStartup))]
namespace Pizzerito.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}