using Grp4.models;
using Grp4.repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grp4.Services.Impl
{
    public class SegmentService : ISegment
    {
        private readonly VconfRepository repo;

        public SegmentService(VconfRepository repo)
        {
            this.repo = repo;
        }

        public async Task<List<Segment>> GetAllSegmentsAsync()
        {
            try
            {
               
                return await repo.Segments.ToListAsync();
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        public async Task<Segment> GetSegmentByIdAsync(int segmentId)
        {
            try
            {
                // Use asynchronous method to get a segment by ID
                return await repo.Segments.FirstOrDefaultAsync(x => x.Id == segmentId);
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
    }
}
