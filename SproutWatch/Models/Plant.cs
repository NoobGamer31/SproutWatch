using System.ComponentModel.DataAnnotations;

namespace SproutWatch.Models
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Spicies { get; set; }
        public DateTime PlantingDate { get; set; } // Gets on create
        public HealthStatus PlantHealthStatus { get; set; } = HealthStatus.Excelent; // Default value. Updates by time

        [Required]
        public double IdealMoisure { get; set; } // Moisure = Humidade

        [Required]
        public double IdealTemperature { get; set; }

        public enum HealthStatus { Excelent, Bad, Critical }
    }
}
