﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HTT.Repository;

namespace HTT.Helpers
{
    /// <summary>
    /// web host extension to run migration and seed data 
    /// </summary>
    public static class WebHostExtension
    {
        /// <summary>
        /// run migrations
        /// </summary>
        /// <param name="webHost"></param>
        /// <returns></returns>
        public static IWebHost MigrateDatabase(this IWebHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<Context>())
                {
                    appContext.Database.Migrate();
                }
            }
            return webHost;
        }
    }
}
