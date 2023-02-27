using System.ComponentModel.DataAnnotations;
namespace stars_in_a_box.Models.Star

{
    public class Star : AstronomicalObject
    {
        private static int StarCount = 0; 

        [Key]
        public int StarID {get; set;}
        public float luminosity { get; set; } //Solar luminosity, 3.83*(10^26) watts
        public float diameter { get; set; } //Solar radius, 695700 km
        public float rotation { get; set; } //km/s
        public int surfaceTemperature { get; set; } //Kelvin
        public float mass { get; set; } //Sun mass, 1.98*(10^30) km
        public string name {get; set;} //Name
        public Star()
        {
            StarCount++;
            StarID = StarCount;
        }
    }
}
