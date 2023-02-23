namespace stars_in_a_box.Models.UniverseStructure
{using System.ComponentModel.DataAnnotations;
    public class GalaxyCluster : AstronomicalObject
    {
        [Key]
        public int GalaxyClusterID {get; set;} //Galaxy cluster ID
        public int numberOfGalaxies {get; set;}
        public float totalMass { get; set;} //in 10^9 Solar masses
        public float diameter { get; set;} //in megaparsecs
        public List<Galaxy> GalaxyList { get; set;} //List of Galaxies in a cluster
    }
}
