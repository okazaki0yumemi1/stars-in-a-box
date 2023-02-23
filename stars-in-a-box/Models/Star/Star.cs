using System.ComponentModel.DataAnnotations;
namespace stars_in_a_box.Models.Star

{
    public class Star : AstronomicalObject
    {
        [Key]
        public int StarID {get; set;} //Star ID
        public float luminosity { get; set; } //Solar luminosity, 3.83*(10^26) watts
        public long diameter { get; set; } //Solar radius, 695700 km
        public int rotation { get; set; } //km/s
        public int surfaceTemperature { get; set; } //Kelvin
        public float mass { get; set; } //Sun mass, 1.98*(10^30) km
    }
}
