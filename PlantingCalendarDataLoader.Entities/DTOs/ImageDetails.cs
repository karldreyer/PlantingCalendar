using PlantingCalendar.Entities.DTOs;

namespace PlantingCalendar.Entities
{
    public class ImageDetails
    {
        public ImageLicenseDetails? LicenseDetails { get; set; }
        public string? OriginalUrl { get; set; }
        public string? RegularUrl { get; set; }
        public string? MediumUrl { get; set; }
        public string? SmallUrl { get; set; }
        public string? Thumbnail { get; set; }


    }
}
