using AutoMapper;
using Microsoft.Extensions.Configuration;
using MyCouch;
using MyCouch.Net;
using PlantingCalendar.ResourceAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantingCalendar.ResourceAccess
{
    public class GenericPlantingCalendarRepository<T> : IGenericPlantingCalendarRepository<T> where T : class
    {
        private readonly MyCouchClient MyCouchClient;

        public GenericPlantingCalendarRepository(IConfiguration configuration)
        {
            var connectionInfo = new DbConnectionInfo(configuration.GetSection("CouchDb:Server").Value, configuration.GetSection("CouchDb:DatabaseName").Value)
            {
                BasicAuth = new BasicAuthString(configuration.GetSection("CouchDb:Username").Value, configuration.GetSection("CouchDb:Password").Value)
            };
            MyCouchClient = new MyCouchClient(connectionInfo);
        }
        public Guid Add(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
