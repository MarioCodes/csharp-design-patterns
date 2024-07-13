using strategyPatternDI.Models;
using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class RequestShipmentModel
    {
        [Required(ErrorMessage = "Details are mandatory")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Type is mandatory")]
        public string Type { get; set; }
    }
}
