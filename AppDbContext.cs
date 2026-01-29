using Microsoft.EntityFrameworkCore;
using eventAPI.Models;
namespace AppDB;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // public DbSet<Event> Events => Set<Event>();
    // public DbSet<RegisteredUser> RegisteredUsers => Set<RegisteredUser>();
}