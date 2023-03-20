using Microsoft.AspNetCore.Mvc;
using Tours_OpenData.Parkings_Indigo;
using Tours_OpenData.Parkings_Indigo.Domain;
using Tours_OpenData.Parkings_Indigo.Infrastructures.Contexts;

namespace Tours_OpenData.Controllers.Parkings.Indigo
{
    [Route("api/parkings/indigo")]
    [ApiController]
    public class ParkingsIndigoController : Controller
    {
        private readonly ParkingContext _context = null;

        private List<Parking> _parkings = new List<Parking>();

        public ParkingsIndigoController(ParkingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //var model = Enumerable.Range(1, 10).Select(item => new Parking());
            var query = from parking in this._context.Parkings
                        select parking;

            return View("Views/Parkings/Indigo/ParkingsIndigo.cshtml");
            //_parkings = query.ToList();
            //return this.Ok(query.ToList());
        }
    }
}
