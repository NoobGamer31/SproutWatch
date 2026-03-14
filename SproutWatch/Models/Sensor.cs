using System.ComponentModel.DataAnnotations;

namespace SproutWatch.Models
{
    public class Sensor
    {
        [Key]
        public Guid MacAdress { get; set; } = new Guid(); 
        
        public DateTime? LastSignalRead { get; set; }

        [Required]
        [Range(0, 100)]
        public int Battery { get; set; }

    }
}
