using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rentt.Application.Common.Interfaces;
using Rentt.Infrastructure.Persistence;

namespace Rentt.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrasctructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<RenttDbContext>(options =>
                   options.UseSqlServer(
                       configuration.GetConnectionString("DefaultConnection"),
                       b => b.MigrationsAssembly(typeof(RenttDbContext).Assembly.FullName)));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<RenttDbContext>());

            return services;
        }


        public static void UpdateDatabase(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<RenttDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
