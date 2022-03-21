using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Application.Persistence.Contracts;
using Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
	public static class PersistenceServicesRegistration
	{
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FuncionarioDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("FuncionarioConnectionString")));



            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

            return services;
        }
    }
}

