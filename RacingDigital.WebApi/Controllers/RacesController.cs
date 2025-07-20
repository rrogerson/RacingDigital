using Microsoft.AspNetCore.Mvc;
using RacingDigital.Models;
using System.Collections.Generic;
using System.Collections;
using RacingDigital.Services.Interfaces;

namespace RacingDigital.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RacesController : ControllerBase
    {
      

        private readonly ILogger<RacesController> _logger;
        private IRacesService _racesService;

        public RacesController(ILogger<RacesController> logger, IRacesService racesService)
        {
            _logger = logger;
            _racesService = racesService;
        }

        [HttpGet]
        public IEnumerable<RaceResult> GetRaces()
        {
            return _racesService.GetRaces();
        }

        [HttpGet("GetNotes/{raceId}")]
        public IEnumerable<Notes> GetNotes(int raceId)
        {
            return _racesService.GetNotes(raceId);
        }

        [HttpPost("AddNote")]
        public IActionResult AddNote([FromBody] Notes item)
        {
            if (item == null)
            {
                return BadRequest("No item provided.");
            }

            try
            {
                int result = _racesService.AddNotes(item);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"UpdateJob error: {ex.Message}");
                // Handle exceptions, return an error response
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }


}
