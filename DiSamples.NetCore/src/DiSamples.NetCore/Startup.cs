using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DiSamples.NetCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //// DEPENDENCY INJECTION
            //// register instance as transient (created each time requested from the service container)
            services.AddTransient<Interfaces.IService, Concrete1.Service1>();
            //services.AddTransient<Interfaces.IService, Concrete2.Service2>();

            //// register instance as scoped (created once per client request/connection)
            //services.AddScoped<Interfaces.IService, Concrete1.Service1>();

            //// register instance as singleton (created once, first time requested or when code implements from container)
            //services.AddSingleton<Interfaces.IService, Concrete1.Service1>();

            //// CAUTION! Do not resolve a scoped service from a singleton 

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
