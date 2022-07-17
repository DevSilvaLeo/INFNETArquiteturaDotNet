using INFNET.Spotfy.Domain.Repository;
using INFNET.Spotfy.Repository.SqlServer.Context;
using INFNET.Spotfy.Repository.SqlServer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFNET.Spotfy.Repository.SqlServer
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SpotifyContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
