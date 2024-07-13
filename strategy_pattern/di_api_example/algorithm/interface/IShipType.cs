using strategyPatternDI.Models;
using System.Threading.Tasks;

namespace strategyPatternDI.algorithm.@interface
{
    public interface IShipType
    {
        string Name { get; }
        Task Ship(string data, ShipmentType type);
    }
}
