using Microsoft.EntityFrameworkCore;
namespace AppDB;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserStatistics> UserData => Set<UserStatistics>();
    public DbSet<CityStatistics> CityData => Set<CityStatistics>();
}