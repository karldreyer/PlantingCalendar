using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantingCalendar.ResourceAccess.Interfaces
{
    public interface IGenericPlantingCalendarRepository<T> where T : class
    {
        Guid Add(T entity);
    }
}
