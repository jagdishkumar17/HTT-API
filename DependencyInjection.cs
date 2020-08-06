using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HTT.Manager.Contract;
using HTT.Repository;
using System.Security.Principal;
using HTT.Manager.Service;
using HTT.Repository.Services;
using HTT.Repository.Contracts;

namespace HTT
{
    /// <summary>
    /// Class used to configure the repository classes
    /// </summary>
    public class DependencyInjection
    {
        internal void ConfigureRepositories(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc();

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IPrincipal>(provider => provider.GetService<IHttpContextAccessor>().HttpContext.User);

            #region Manager
            services.AddTransient<IHealthTrackService, HealthTrackService>();
            #endregion

            #region Repositories
            services.AddTransient<IHealthTrackRepository, HealthTrackRepository>();
            #endregion

        }
    }
}
