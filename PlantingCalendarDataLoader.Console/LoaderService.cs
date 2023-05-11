using PlantingCalendar.DataLoader.Console.Interfaces;
using PlantingCalendar.ResourceAccess.Interfaces;

namespace PlantingCalendar.DataLoader.Console
{
    public class LoaderService : ILoaderService
    {
        private IPlantingCalendarRepository _plantingCalendarRepository;

        public LoaderService(IPlantingCalendarRepository plantingCalendarRepository)
        {
            _plantingCalendarRepository = plantingCalendarRepository;
        }

        public void Run()
        {
            _plantingCalendarRepository.LoadPlant(new Entities.DTOs.Plant());
        }
    }
}
