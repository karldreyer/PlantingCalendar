using PlantingCalendar.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantingCalendar.ResourceAccess.Interfaces
{
    public interface IMapper
    {
        Plant MapPlantDtoToPlantModel(Entities.DTOs.Plant plant);
        Entities.DTOs.Plant MapPlantModelToPlantDto(Plant plant);
    }
}
