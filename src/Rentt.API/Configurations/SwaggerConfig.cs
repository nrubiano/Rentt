using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace Rentt.API.Configurations
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfig(this IServiceCollection services) { 
            
            if(services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Rentt - Your Movie Rental Service",
                    Description = "Rentt - Your Movie Rental Service",
                    Contact = new OpenApiContact { Name = "Nicolas Rubiano", Email = "nicolas.rubiano@outlook.com" },
                    License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://github.com/nrubiano/Rentt/blob/main/LICENSE") }
                });
            });
        }

        public static void UseSwaggerConfig(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
