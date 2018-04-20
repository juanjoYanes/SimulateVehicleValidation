using System.Web.Http;
using System.Web.Mvc;


namespace VehicleValidationSimulatorApp.Controllers
{
    public class VehicleController : Controller
    {

        public ActionResult Validation()
        {
            ViewBag.Title = "Vehicle Validation";

            return View("validation");
        }

    }
}
