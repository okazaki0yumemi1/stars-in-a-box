using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;

namespace stars_in_a_box.Models.UniverseStructure
{
    public class Galaxy : AstronomicalObject
    {
        [Key]
        public int GalaxyID {get; set;} //Galaxy ID
        public byte shape { get; set; } //Hubble Shape, from -6 to 11
        public float mass { get; set; } //in million (10^6) Solar Masses
        public int size { get; set; } //in thousands (10^3) light years
        public int numberOfStars { get; set; } //in billions (10^9) stars
        public List<Models.Star.Star> StarList { get; set; } //List of stars in a galaxy
    }
}
