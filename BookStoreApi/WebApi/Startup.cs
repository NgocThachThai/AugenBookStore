using DataAccessor;
using DataAccessor.Repositories;
using DataAccessor.Repositories.Implemetation;
using DataAccessor.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.IServices;
using Services.Services;

namespace WebApi
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
            services.AddControllers();
            RegisterService(services);
            RegisterDataLayer(services);
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
        private static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<IVendorService, VendorService>();
            services.AddScoped<IBookService, BookService>();

        }
        private static void RegisterDataLayer(IServiceCollection services)
        {
            services.AddSingleton<IDatabaseContext, DatabaseContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IVendorRepository, VendorRepository>();

        }
    }
}
