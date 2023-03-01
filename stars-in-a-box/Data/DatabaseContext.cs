namespace stars_in_a_box;
using Microsoft.EntityFrameworkCore;

public class DatabaseConnection : DbContext
{
    public DatabaseConnection (DbContextOptions<DatabaseConnection> options) : base(options)
    {
    }
    public DbSet<Models.Star.Star> Stars {get; set;}
    public DbSet<Models.UniverseStructure.Galaxy> Galaxies {get; set;}
    public DbSet<Models.UniverseStructure.GalaxyCluster> GalaxyClusters {get; set;}    
}