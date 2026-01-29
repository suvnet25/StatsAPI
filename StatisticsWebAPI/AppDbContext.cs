using Microsoft.EntityFrameworkCore;
namespace AppDB;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Statistics> Data => Set<Statistics>();
}