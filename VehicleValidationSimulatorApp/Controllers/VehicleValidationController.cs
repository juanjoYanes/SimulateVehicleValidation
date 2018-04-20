using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VehicleValidationSimulatorApp.Models.Vehicle;

namespace VehicleValidationSimulatorApp.Controllers
{
    public class VehicleValidationController : ApiController
    {
        // POST api/<controller>
        [ActionName("ProcessVehicle")]
        [HttpPost]
        public IHttpActionResult ProcessVehicle([FromBody]VehicleRequest vehicleToProcess)
        {
            ProcessVehicleResponse resultVehicleResponse = new ProcessVehicleResponse();

            resultVehicleResponse.VehicleId = vehicleToProcess.VehicleId;
            resultVehicleResponse.ReturnCode = VehicleValidationResultCode.Valid;

            if ((!ModelState.IsValid) || (vehicleToProcess.Type == null) || (vehicleToProcess.ManufacturerNameShort == null))
            {
                resultVehicleResponse.ReturnCode = VehicleValidationResultCode.Invalid;
            }

            return Ok(resultVehicleResponse);
        }
    }
}