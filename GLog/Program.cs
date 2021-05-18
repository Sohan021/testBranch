using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace GLog
{
    public class Program
    {
 
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .ConfigureLogging(loggingConfiguration => loggingConfiguration.ClearProviders());
            //.UseSerilog((hostingContext, loggerConfiguration) =>
            //    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));
    }
}
