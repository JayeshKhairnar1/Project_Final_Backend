using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetProject.Services
{
    public interface IVehicle
    {
        Task<List<dynamic>> GetCompByModelIDAsync(long id, string compType);
        Task<List<dynamic>> GetConfigurableComponentsAsync(long id, string isConfigurable);
        Task<List<dynamic>> GetVehicleDataUsingModelIdAsync(int modId);
    }
}
