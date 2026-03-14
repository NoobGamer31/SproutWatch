using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SproutWatch.Models
{
    public class SensorDataLog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid MacAdress { get; set; }
        
        [ForeignKey("MacAdress")]
        public Sensor Sensor { get; set; }

        [Required]
        public double Moisure { get; set; }
        
        [Required]
        public double Temperature { get; set; }

        [Required]
        public double Luminosity { get; set; }
    }
}
