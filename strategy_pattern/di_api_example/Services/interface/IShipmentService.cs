using strategyPatternDI.Models;
using System.Threading.Tasks;

namespace strategyPatternDI.Services.@interface
{
    public interface IShipmentService
    {
        Task Ship(string data, ShipmentType type);
    }
}
