using PlantingCalendar.Entities;

namespace PlantingCalendar.ResourceAccess.Interfaces
{
    public interface IPlantingCalendarRepository
    {
        int AddPlant(Plant plant);
    }
}