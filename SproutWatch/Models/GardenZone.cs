using System.ComponentModel.DataAnnotations;

namespace SproutWatch.Models
{
    public class GardenZone
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public AmbientType GardenAmbientType { get; set; } 

        public int UserId { get; set; } // Gets via UserManager
        public enum AmbientType { Indoor, Outdoor }
    }
}
