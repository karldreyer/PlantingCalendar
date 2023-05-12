namespace PlantingCalendar.Entities.DTOs
{
    public class Plant
    {
        public string? CommonName { get; set; }
        public IList<string>? ScientificNames { get; set; }
        public string? Cycle { get; set; }
        public string? Watering { get; set; }
        public IList<string>? Sunlight { get; set; }
        public ImageDetails? ImageDetails { get; set; }
    }
}
