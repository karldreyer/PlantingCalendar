using Microsoft.AspNetCore.Mvc;
using PlantingCalendar.Entities;
using PlantingCalendar.ResourceAccess.Interfaces;
using System.Diagnostics.Metrics;

namespace PlantingCalendar.Command.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private readonly ILogger<PlantsController> _logger;
        private readonly IPlantingCalendarRepository _plantingCalendarRepository;

        public PlantsController(ILogger<PlantsController> logger, IPlantingCalendarRepository plantingCalendarRepository)
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
            var newPlantId = _plantingCalendarRepository.AddPlant(plant);
            return CreatedAtAction(nameof(GetPlant), new { id = newPlantId });
        }

        
    }
}