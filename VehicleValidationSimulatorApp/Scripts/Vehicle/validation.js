$(document).ready(function () {
    var urlVehicleValidationAPI = "../api/VehicleValidation/ProcessVehicle";

    $('#btnValidateVehicle').click(function () {
        var dataVehicleResponse = {
                VehicleId: $('#VehicleId').val(),
                Type: $('#Type').val(),
                ManufacturerNameShort: $('#ManufacturerNameShort').val(),
                Price: $('#Price').val()
            };

        $.post(urlVehicleValidationAPI, dataVehicleResponse, function (response, state) {
            if (state === 'success') {
                $('#responsevehiclevalidation').html("").hide();

                if (response.ReturnCode == 1) { // vehicle invalid
                    $('#responsevehiclevalidation').html("Invalid Vehicle Request").show();
                }
                else { // other cases
                    $('#responsevehiclevalidation').html("Valid Vehicle Request").show();
                }
            }
            else {
                $('#responsevehiclevalidation').html("").hide();
                console.log('response -> ', response);
                console.log('state -> ', state);
            }
        }, 'json');

    });

    $('VehicleId').html('');
    $('Type').html('');
    $('ManufacturerNameShort').html('');
    $('Price').html('');
    $('#responsevehiclevalidation').hide();
});