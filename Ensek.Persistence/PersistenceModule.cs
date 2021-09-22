using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text;

namespace Ensek.Persistence
{
    public static class PersistenceModule
    {
        public static void RegisterPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            services.AddDbContext<EnsekDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Ensek")));
        }
    }
}