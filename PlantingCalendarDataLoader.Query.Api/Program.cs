using Serilog;

namespace PlantingCalendar.Query.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var allowAllPolicyName = "AllowAll";

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(allowAllPolicyName, p => p.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            });

            builder.Host.UseSerilog((context, loggerConfiguration) =>
            {
                loggerConfiguration.WriteTo.Console().ReadFrom.Configuration(context.Configuration);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(allowAllPolicyName);

            app.MapControllers();

            app.Run();
        }
    }
}