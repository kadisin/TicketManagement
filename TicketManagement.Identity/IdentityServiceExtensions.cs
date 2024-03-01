using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketManagement.Identity.Models;

namespace TicketManagement.Identity
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(IdentityConstants.ApplicationScheme).AddIdentityCookies();
            services.AddAuthorizationBuilder();

            services.AddDbContext<TicketIdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TicketIdentityConeectionString")));

            services.AddIdentityCore<ApplicationUser>().AddEntityFrameworkStores<TicketIdentityDbContext>().AddApiEndpoints();
            return services;
        }
    }
}
