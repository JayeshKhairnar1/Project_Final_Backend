using System.Collections.Generic;
using System.Threading.Tasks;
using Grp4.models;

namespace VconfigDotnet.Services
{
    public interface IManufacturer
    {
        Task<List<Manufacturer>> GetManufacturerBySegIdAsync(int segId); 
    }
}
