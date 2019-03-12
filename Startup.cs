using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using swhalley.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace dotnet_api_oauth
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PersonContext>( ctx => ctx.UseMySQL( Configuration.GetConnectionString("ContactDb")));

            //EF Core by default has a circular loop structure. To prevent the JSON parser from throwing an error
            //when a response is serializing, the json options are added to ignore the circular reference when it is found.
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions( options => {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //This block of code is for applications with no database. EF Core allows you to auto create
            //the database if one doesn't exist. For development purposes this may be useful.
            using( var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope()){
                var context = scope.ServiceProvider.GetService<PersonContext>();
                context.Database.EnsureCreated();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}
