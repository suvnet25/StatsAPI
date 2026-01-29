using AppDB;
using Microsoft.EntityFrameworkCore;

namespace StatisticsWebAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=servers.db"));

            builder.Services.AddControllers();

            //Låt detta vara kvar! Utan denna inställning kommer inte websidan att få access till API:et.
            // Läs mer här: https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/CORS
            builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });

            var app = builder.Build();
            using var scope = app.Services.CreateScope();

            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            db.Database.EnsureCreated();

            // Denna hör ihop med CORS-inställningen ovan
            app.UseCors();

            //Ni ska inte skriva era endpoints här i Program.cs utan i separata controllers, så använd denna:
            app.MapControllers();

            app.Run();
        }
    }
}