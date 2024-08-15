using System.Collections.Generic;
using System.Threading.Tasks;
using Grp4.models;

namespace Grp4.Services
{
    public interface ISegment
    {
        Task<List<Segment>> GetAllSegmentsAsync(); 
        Task<Segment> GetSegmentByIdAsync(int segmentId);
    }
}
