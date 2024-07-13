using strategyPatternDI.algorithm.@interface;
using strategyPatternDI.Models;
using strategyPatternDI.Services.@interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace strategyPatternDI.Services
{
    public class ShipmentService : IShipmentService
    {
        private readonly IEnumerable<IShipType> _allShipTypes;

        public ShipmentService(IEnumerable<IShipType> allShipTypes)
        {
            _allShipTypes = allShipTypes;
        }

        public async Task Ship(string data, ShipmentType type)
        {
            // this gets the correct strategy depending on the type we're dealing with, and runs its method
            var shipStrategy = _allShipTypes.FirstOrDefault(strategy => strategy.Name.Equals(type.ToString()));
            await shipStrategy.Ship(data, type);
        }
    }
}
