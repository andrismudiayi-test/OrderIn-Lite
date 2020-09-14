
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderInLite.Repository;
using OrderInLite.Service;
using OrderInLite.Interfaces;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;


namespace OrderInLite
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

            services.AddTransient<IRepositoryService, RepositoryService>();
            services.AddTransient<IOrderService, OrderService>();
            
            var dbServer = Configuration["DbServerSwitch"];
            
            if(dbServer.ToLower() == "sqlserver")
            {                
                services.AddDbContext<OrderInLiteDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));
            }
            else {                
                services.AddDbContext<OrderInLiteDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("PostgresServerConnection")));
            }

            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "OrderIn-Lite API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
