using Microsoft.AspNetCore.Mvc;
using PlantingCalendar.Entities.DTOs;
using PlantingCalendar.Entities.Models;
using PlantingCalendar.ResourceAccess.Interfaces;
using System.Diagnostics.Metrics;
using Plant = PlantingCalendar.Entities.DTOs.Plant;

namespace PlantingCalendar.Command.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private readonly ILogger<PlantsController> _logger;
        private readonly IPlantRepository _plantingCalendarRepository;

        public PlantsController(ILogger<PlantsController> logger, IPlantRepository plantingCalendarRepository)
        {
            _logger = logger;
            _plantingCalendarRepository = plantingCalendarRepository;
        }

        [HttpGet("id")]
        public async Task<ActionResult<Plant>> GetPlant(int id)
        {
            return null;
        }

        [HttpPost]
        public async Task<ActionResult> AddPlant(Plant plant)
        {
            return null;
            //var newPlantId = _plantingCalendarRepository.AddPlant(plant);
            //return CreatedAtAction(nameof(GetPlant), new { id = newPlantId });
        }

        
    }
}