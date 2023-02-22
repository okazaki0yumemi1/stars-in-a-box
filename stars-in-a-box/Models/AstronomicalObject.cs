using System.ComponentModel.DataAnnotations;

namespace stars_in_a_box.Models
{
    public abstract class AstronomicalObject
    {
        [Key]
        Guid id { get; set; }
        [Required]
        string name { get; set; }

    }
}
