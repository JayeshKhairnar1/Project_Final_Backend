using Microsoft.AspNetCore.Mvc;
using VconfigDotnet.Services; 
using System.Collections.Generic;
using System.Threading.Tasks;
using Grp4.models;

namespace VconfigDotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturer _manufacturerService;

        public ManufacturerController(IManufacturer manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        // GET api/manufacturer/manu-by-segId/{segId}
        [HttpGet("{segId}")]
        public async Task<ActionResult<List<Manufacturer>>> GetManufacturersBySegId(int segId)
        {
            try
            {
                var manufacturers = await _manufacturerService.GetManufacturerBySegIdAsync(segId);
                if (manufacturers != null && manufacturers.Count > 0)
                {
                    return Ok(manufacturers);
                }
                else
                {
                    return NotFound("No manufacturers found for the given segment ID.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
