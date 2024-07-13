using crud.Models;
using Microsoft.AspNetCore.Mvc;
using strategyPatternDI.Models;
using strategyPatternDI.Services.@interface;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace crud.Controllers
{
    // add api versioning
    [ApiController]
    [Route("shipment")]
    public class ShipmentController : ControllerBase
    {
        private IShipmentService _service;

        public ShipmentController(IShipmentService service)
        {
            _service = service;
        }

        [HttpPost("ship")]
        [SwaggerOperation(Tags = new[] { "shipment" })]
        public async Task<IActionResult> LogShipment([FromBody] RequestShipmentModel shipmentModel)
        {
            try
            {
                // do validation
                Enum.TryParse(shipmentModel.Type, out ShipmentType type);
                await _service.Ship(shipmentModel.Details, type);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
