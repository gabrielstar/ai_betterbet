namespace ai_betterbet
{
    using ai_betterbet.Model;
    using ai_betterbet.Repositories;
    using ai_betterbet.Services;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Defines the <see cref="Startup" />
    /// </summary>
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// <summary>
        /// The ConfigureServices
        /// </summary>
        /// <param name="services">The services<see cref="IServiceCollection"/></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IRepository<Team>,TeamsRepository>();
            services.AddSingleton<ITeamsService<Team>, TeamsService>();
            services.AddSingleton<IFinancialService, FinancialService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// The Configure
        /// </summary>
        /// <param name="app">The app<see cref="IApplicationBuilder"/></param>
        /// <param name="env">The env<see cref="IHostingEnvironment"/></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            //custom routes via Conventional routing
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "healthcheck",
                    template: "healtcheck",
                    defaults: new { controller = "Home", action = "healthcheck" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //routing but with static files retrieval if extension exists - for SPA
                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
            //default
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("This is better bet ai");
            });
        }
    }
}
