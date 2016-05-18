using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using SitecoreReference.Services;
using Microsoft.AspNet.Routing;
using Microsoft.Extensions.PlatformAbstractions;
using SitecoreReference.Dal;

namespace SitecoreReference
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<ITeamMemberProfileService, TeamMemberProfileService>();
            services.AddSingleton<IClientCommentService, ClientCommentService>();
            services.AddSingleton<IServicesService, ServicesService>();
            services.AddSingleton<IRecentWorkService, RecentWorkService>();
            services.AddSingleton<ILocationService, LocationService>();
            services.AddSingleton<IDataSource, JsonDataSource>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
            IHostingEnvironment environment,
            IApplicationEnvironment env)
        {
            app.UseIISPlatformHandler();

            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRuntimeInfoPage("/info");

            app.UseFileServer();

            app.UseContentFolder(env);

            app.UseScriptsFolder(env);

            app.UseImagesFolder(env);

            app.UseFontsFolder(env);

            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}"); 
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
