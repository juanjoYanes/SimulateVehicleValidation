using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleValidationSimulatorApp.Models.Vehicle
{
    public enum VehicleValidationResultCode { Valid, Invalid, NotSpecified };

    public class ProcessVehicleResponse
    {
        public int VehicleId { get; set; }
        public VehicleValidationResultCode ReturnCode { get; set; }
    }
}