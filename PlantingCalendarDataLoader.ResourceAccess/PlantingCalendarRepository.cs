using PlantingCalendar.Entities;
using PlantingCalendar.ResourceAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantingCalendar.ResourceAccess
{
    public class PlantingCalendarRepository : IPlantingCalendarRepository
    {
        public int AddPlant(Plant plant)
        {
            return 1;
        }
    }
}
