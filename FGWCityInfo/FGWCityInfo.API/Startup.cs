using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization; //Added if i want to stop CAML casing on return JSON objects by overriding Serializing Setting in MVC now commented
using Microsoft.AspNetCore.Mvc.Formatters;
using FGWCityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using FGWCityInfo.API.Helper;

namespace FGWCityInfo.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();


            //the below allows us to accept headers besides the default JSON 
            // in this case output of XML
            services.AddMvc()
                    .AddMvcOptions((o => o.OutputFormatters.Add(
                        new XmlDataContractSerializerOutputFormatter()
                       )));

            var connString = @"Server=127.0.0.1;Database=CityInfoDb;User Id=sa;Password=P@ssw0rd1!;";

            services.AddDbContext<CityInfoContext>(o => o.UseSqlServer(connString));

            //services.AddMvc()
            //        .AddJsonOptions((o => {
            //            if (o.SerializerSettings.ContractResolver != null)
            //    {
            //                var castedResolver = o.SerializerSettings.ContractResolver
            //                                      as DefaultContractResolver;
            //                castedResolver.NamingStrategy = null;
            //    }
            //}));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, 
                              CityInfoContext cityInfoContext)
        {
            loggerFactory.AddConsole();

            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            //uses to seed the SQLCore Database in the Docker Container
            cityInfoContext.EnsureSeedDataForContext();

            //to ensure that pages done just bomb out
            app.UseStatusCodePages();

            app.UseMvc();

            //app.Run((context) =>
            //{
            //    throw new Exception("Example Exception");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
