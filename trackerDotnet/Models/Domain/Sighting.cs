using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace trackerDotnet.Models.Domain
{
    /// <summary>
    /// Domain Class for Sighting
    /// </summary>

    [Table("Sighting")]
    public class Sighting
    {
        //PK
        public int Id { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }
        [Required]
        public string? Animal { get; set; }
        [Required]
        public decimal Latitude { get; set; }
        [Required]
        public decimal Longitude { get; set; }

        //Relationships
        [Required]
        public int SenderId { get; set; }
        [Required]
        public User? Sender { get; set; }

    }
}
