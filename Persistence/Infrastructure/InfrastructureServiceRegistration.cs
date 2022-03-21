

using Application.Persistence.Contracts;
using Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
	public static class InfrastructureServiceRegistration
	{
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<Application.Models.EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<IEmailSender, MailSender>();
            
            return services;
        }
    }
}

