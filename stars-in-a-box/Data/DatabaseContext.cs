namespace stars_in_a_box;
using Microsoft.EntityFrameworkCore;

public class DatabaseConnection : DbContext
{
    protected readonly IConfiguration Configuration;

    public DatabaseConnection (IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public DbSet<Models.Star.Star> Stars {get; set;}
    public DbSet<Models.UniverseStructure.Galaxy> Galaxies {get; set;}
    public DbSet<Models.UniverseStructure.GalaxyCluster> GalaxyClusters {get; set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }
    
}