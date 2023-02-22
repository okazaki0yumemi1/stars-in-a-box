namespace stars_in_a_box.Models.UniverseStructure
{
    public class GalaxyCluster : AstronomicalObject
    {
        public int numberOfGalaxies {get; set;}
        public float totalMass { get; set;} //in 10^9 Solar masses
        public float diameter { get; set;} //in megaparsecs
        public List<Galaxy> GalaxyList { get; set;} //List of Galaxies in a cluster
    }
}
