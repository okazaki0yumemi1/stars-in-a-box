using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using stars_in_a_box;
using System;
using System.Linq;
namespace stars_in_a_box;

public static class SeedingTheDatabase
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new DatabaseConnection(serviceProvider.GetRequiredService<DbContextOptions<DatabaseConnection>>()))
        {
            if (context.Stars.Any()) return;
            context.Stars.AddRange(
                new Models.Star.Star
                {
                    diameter = 1, luminosity = 1, mass = 1, rotation = (float)(2.77), surfaceTemperature = 5772, name = "Sol"
                },
                new Models.Star.Star
                {
                    diameter = (float)(2.42), luminosity = (float)(1.5), mass = (float)(1.007), rotation = (float)(2.7), surfaceTemperature = 5790, name = "Alpha Centauri A"
                },
                new Models.Star.Star
                {
                    diameter = (float)(1.72), luminosity = (float)(0.49), mass = (float)(0.909), rotation = (float)(1.1), surfaceTemperature = 5260, name = "Alpha Centauri B"
                },
                new Models.Star.Star
                {
                    diameter = (float)(0.3), luminosity = (float)(0.0015), mass = (float)(0.1221), rotation = (float)(0.08), surfaceTemperature = 2992, name = "Proxima Centauri"
                }
            );
            context.SaveChanges();
        }
    }
    
}