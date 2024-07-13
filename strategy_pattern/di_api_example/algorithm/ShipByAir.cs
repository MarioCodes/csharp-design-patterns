using strategyPatternDI.algorithm.@interface;
using strategyPatternDI.Models;
using System;
using System.Threading.Tasks;

namespace strategyPatternDI.algorithm
{
    public class ShipByAir : IShipType
    {
        public string Name => ShipmentType.Air.ToString();
        public async Task Ship(string data, ShipmentType type)
        {
            Console.WriteLine("we're shipping something by air");
        }
    }
}
