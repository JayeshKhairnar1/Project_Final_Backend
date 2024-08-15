using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetProject.Services;

namespace DotNetProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicle _vehicleService;

        public VehicleController(IVehicle vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("components/{compType}/{modid}")]
        public async Task<IActionResult> GetComponentsByModelId(string compType, long modid)
        {
            try
            {
                var components = await _vehicleService.GetCompByModelIDAsync(modid, compType);
                return Ok(components);
            }
            catch
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpGet("configurable/{id}/{isConfigurable}")]
        public async Task<IActionResult> GetConfigurableComponentsByModelId(long id, string isConfigurable)
        {
            try
            {
                var components = await _vehicleService.GetConfigurableComponentsAsync(id, isConfigurable);
                return Ok(components);
            }
            catch
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        [HttpGet("details/{modId}")]
        public async Task<IActionResult> GetVehicleDataUsingModelId(int modId)
        {
            try
            {
                var vehicleDetails = await _vehicleService.GetVehicleDataUsingModelIdAsync(modId);
                return Ok(vehicleDetails);
            }
            catch
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}
