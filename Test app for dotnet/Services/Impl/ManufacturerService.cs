using Grp4.models;
using Grp4.repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VconfigDotnet.Services.Impl
{
    public class ManufacturerService : IManufacturer
    {
        private readonly VconfRepository _repo;

        public ManufacturerService(VconfRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Manufacturer>> GetManufacturerBySegIdAsync(int segId)
        {
            try
            {
              
                List<Manufacturer> manuList = await _repo.Manufacturers
                    .Where(x => x.SegId == segId)
                    .ToListAsync();

                return manuList;
            }
            catch (Exception ex)
            {
               
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
    }
}
