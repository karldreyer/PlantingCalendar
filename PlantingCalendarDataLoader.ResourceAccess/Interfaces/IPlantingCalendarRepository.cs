using PlantingCalendar.Entities.DTOs;

namespace PlantingCalendar.ResourceAccess.Interfaces
{
    public interface IPlantingCalendarRepository
    {
        void LoadPlant(Plant plant);
    }
}