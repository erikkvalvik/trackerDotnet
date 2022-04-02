namespace trackerDotnet.Models.DTO.Sighting
{
    public class SightingReadDTO
    {
        public int Id { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Animal { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int SenderId { get; set; }
    }
}
