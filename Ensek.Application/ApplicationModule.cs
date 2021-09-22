using Ensek.Application.Validators;
using Ensek.Application.Validators.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Ensek.Tests")]
namespace Ensek.Application
{
    public static class ApplicationModule
    {
        public static void RegisterApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IValidateMeterReading, MeterReadingValidator>();
        }
    }
}