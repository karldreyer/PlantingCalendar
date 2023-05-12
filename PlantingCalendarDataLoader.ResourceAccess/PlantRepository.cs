using Microsoft.Extensions.Configuration;
using PlantingCalendar.Entities.DTOs;
using PlantingCalendar.Entities.Models;
using PlantingCalendar.ResourceAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plant = PlantingCalendar.Entities.Models.Plant;

namespace PlantingCalendar.ResourceAccess
{
    public class PlantRepository : GenericPlantingCalendarRepository<Plant>, IPlantRepository
    {
        public PlantRepository(IConfiguration configuration) : base(configuration) { } 
    }
}
