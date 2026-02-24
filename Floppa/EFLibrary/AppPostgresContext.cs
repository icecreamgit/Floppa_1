using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EFLibrary.Models;

namespace EFLibrary;
public class AppPostgresContext(IConfiguration configuration) : DbContext
{
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("PgConnection"));
    }
}
