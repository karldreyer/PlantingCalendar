using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlantingCalendar.DataLoader.Console.Interfaces;
using PlantingCalendar.ResourceAccess;
using PlantingCalendar.ResourceAccess.Interfaces;
using Serilog;

namespace PlantingCalendar.DataLoader.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);
            SetupLogging(builder);
            IHost host = SetupHostDetails();
            var svc = ActivatorUtilities.CreateInstance<LoaderService>(host.Services);
            svc.Run();

        }

        private static IHost SetupHostDetails()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    SetupDependencyInjection(services);
                })
                .UseSerilog()
                .Build();
        }

        private static void SetupDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<IPlantingCalendarRepository, PlantingCalendarRepository>();
            services.AddTransient<ILoaderService, LoaderService>();
        }

        private static void SetupLogging(ConfigurationBuilder builder)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();
        }

        static void BuildConfig(IConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}