using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Laboratorio152
{
    public class Startup
    {
        // Este método es llamado en la ejecución. Usa este método para agregar los servicios al contenedor
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // Este método es llamado en la ejecución. Usa este método para configurar el HTTP Request Pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
