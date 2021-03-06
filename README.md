# Simulate Vehicle Validation

Task: Simulate a formular validation through a Restful API.

Notes:
### ASP.NET ###
### Clean Code ###
#### c# ####


Create a view with 4 inputfields (properties of VehicleRequest) and a submit-button. 
When the button is pressed, create an object VehicleRequest with the following structure:

```
public class VehicleRequest
{
	public int VehicleId { get; set; }
	public string Type { get; set; }
	public string ManufacturerNameShort { get; set; }
	public decimal Price { get; set; }
}
```

Send the created object to a method 'ProcessVehicle' of a Rest API. 
This method should take the VehicleRequest-object and return a ProcessVehicleResponse
 object with the following structure:
```
public class ProcessVehicleResponse
{
	public int VehicleId { get; set; }
	public VehicleValidationResultCode ReturnCode { get; set; }
}
```
The VehicleId should remain the same, the ReturnCode should return possible states (Enum):
Valid, Invalid, NotSpecified (as default).
- NotSpecified must never be returned 
- Invalid, when any of the values is null or empty
- Valid in all other cases
Visualize the result 



