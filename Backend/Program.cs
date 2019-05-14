using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace swhalley
{
    //Application created from 
    //dotnet new webapi -o appName
    //Here is a good tutorial
    //https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.2&tabs=visual-studio-code
    //
    //Additional dependencies added using. Following adds MYSQL Support to the application
    //dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.15
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.conf").GetCurrentClassLogger();

            try {
                logger.Error("Application is starting - Hello Logger");
                CreateWebHostBuilder(args).Build().Run();
            } finally {
                NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging( configureLogging => {
                    configureLogging.ClearProviders();
                    configureLogging.SetMinimumLevel( LogLevel.Trace );
                })
                .UseNLog();
    }
}
