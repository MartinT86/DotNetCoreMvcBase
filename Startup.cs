using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Logging;

namespace aspnetcoreapp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Error);

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
            routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            // app.Run(context =>
            // {
            //     return context.Response.WriteAsync("Hello from ASP.NET Core!");
            // });
        }
    }
}