using crud.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using strategyPatternDI.algorithm;
using strategyPatternDI.algorithm.@interface;
using strategyPatternDI.Services;
using strategyPatternDI.Services.@interface;

namespace crud
{
    public class Startup
    {

        public IConfiguration _config { get; }

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Service Configuration
            services.AddControllers();
            services.AddSwaggerGen();

            // Services
            services.AddTransient<IShipmentService, ShipmentService>();
            services.AddTransient<IShipType, ShipByAir>();
            services.AddTransient<IShipType, ShipByGround>();
            services.AddTransient<IShipType, ShipBySea>();

            // Database
            services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase(databaseName: "InMemoryTestDatabase"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = string.Empty;
                });
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
