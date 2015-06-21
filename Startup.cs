using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace vNextTutorial
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Add MVC services to the services container.
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute("Index", null, new { controller = "Home", action = "Index" });
            });
        }
    }

}
