using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VehicleValidationSimulatorApp.Models.Vehicle
{
    public class VehicleRequest
    {
        [Required(ErrorMessage = "Error. 'VehicleId' cannot be an empty value")]
        public int VehicleId { get; set; }
        
        [Required(ErrorMessage = "Error. 'Type' cannot be an empty value")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Error. 'Manufacturer Name Short' cannot be an empty value")]
        [Display(Name = "Manufacturer")]
        public string ManufacturerNameShort { get; set; }

        [Required(ErrorMessage = "Error. 'Price' cannot be an empty value")]
        public decimal Price { get; set; }
    }
}