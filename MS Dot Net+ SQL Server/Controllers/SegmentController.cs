using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Grp4.models;
using Grp4.Services;

namespace VconfigDotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SegmentController : ControllerBase
    {
        private readonly ISegmentService _segmentService;

        public SegmentController(ISegmentService segmentService)
        {
            _segmentService = segmentService;
        }

        // GET api/segment
        [HttpGet]
        public ActionResult<List<Segment>> GetAllSegments()
        {
            try
            {
                var segments = _segmentService.GetAllSegments();
                return Ok(segments);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        
    }
}
