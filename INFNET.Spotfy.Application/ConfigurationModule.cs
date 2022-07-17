using INFNET.Spotfy.Application.Services;
using INFNET.Spotfy.Application.Services.Interface;
using INFNET.Spotfy.Repository.SqlServer;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services, string connectionString)
        {
            services.RegisterRepository(connectionString);

            services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);

            services.AddMediatR(typeof(Application.ConfigurationModule).Assembly);

            services.AddScoped<IAlbumServices, AlbumService>();

            return services;

        }
    }
}
