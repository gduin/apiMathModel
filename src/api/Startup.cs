using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace api
{
    public class modelsParams
    {
        public Dictionary<string, parameters> models { get; set; }
    }
     public class parameters
    {
        public string Interpreter {get; set;}
        public string ScriptFile {get; set;}
    }
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
            services.Configure<modelsParams>(Configuration);
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            try
            {
                var jsonConfig = File.ReadAllText("config/models.json");
                var dict = JsonSerializer.Deserialize<modelsParams>(jsonConfig);
                // var config = new ConfigurationBuilder();
                // config.AddJsonFile("config/models.json");
                // //config.AddEnvironmentVariables()
                // config.Build();
                //EnvironmentVariablesExtensions.AddEnvironmentVariables();   
            }
            catch (System.Exception)
            {
                Console.WriteLine("Exception: config/models.json");
                throw;
            }

            
            //var tst1 = JsonSerializer.se;

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
