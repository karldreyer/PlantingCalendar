using PlantingCalendar.Entities.DTOs;
using PlantingCalendar.Entities.Models;
using Plant = PlantingCalendar.Entities.Models.Plant;

namespace PlantingCalendar.ResourceAccess.Interfaces
{
    public interface IPlantRepository : IGenericPlantingCalendarRepository<Plant>
    {
    }
}