using librarygraphql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace librarygraphql
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("connectionString");
            services.AddDbContext<LibraryContext>(o => o.UseSqlServer(connectionString));
        }
    }
}