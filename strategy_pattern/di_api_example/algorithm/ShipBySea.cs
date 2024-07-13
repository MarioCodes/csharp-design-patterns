using strategyPatternDI.algorithm.@interface;
using strategyPatternDI.Models;
using System;
using System.Threading.Tasks;

namespace strategyPatternDI.algorithm
{
    public class ShipBySea : IShipType
    {
        public string Name => ShipmentType.Sea.ToString();

        public async Task Ship(string data, ShipmentType type)
        {
            Console.WriteLine("we're shipping something by Sea");
        }
    }
}
