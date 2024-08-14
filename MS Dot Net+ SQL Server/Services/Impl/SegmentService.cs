using System;
using System.Collections.Generic;
using System.Linq;
using Grp4.models;
using Grp4.repositories;

namespace Grp4.Services.Impl
{
    public class SegmentService : ISegmentService
    {
        private readonly VconfRepository _repo;

        public SegmentService(VconfRepository context)
        {
            _repo = context;
        }

        public List<Segment> GetAllSegments()
        {
            try
            {
                List<Segment> list = _repo.Segments.ToList();
                Console.WriteLine(list.Count); // Consider using a logging framework instead
                return list;
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}"); // Or use a logging framework
                throw; // Rethrow the exception to be caught in the controller
            }
        }

        
    }
}
