using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace trackerDotnet.Models.Domain
{
    /// <summary>
    /// Domain Class for User
    /// </summary>
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }

        //public ICollection<Sighting> Sightings { get; set; }
    }
}
