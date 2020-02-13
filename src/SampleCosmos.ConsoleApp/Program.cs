using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace SampleCosmos.ConsoleApp
{
    public class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        private static void Main()
        {
            var devEnvironmentVariable = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");

            var isDevelopment = string.IsNullOrEmpty(devEnvironmentVariable) ||
                                devEnvironmentVariable.ToLower() == "development";
            //Determines the working environment as IHostingEnvironment is unavailable in a console app

            var builder = new ConfigurationBuilder();

            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            //only add secrets in development
            if (isDevelopment)
            {
                builder.AddUserSecrets<Program>();
            }

            Configuration = builder.Build();

            Console.WriteLine(Configuration["CosmosDB:accountEndpoint"]);


            Console.ReadKey();

        }
    }
}
