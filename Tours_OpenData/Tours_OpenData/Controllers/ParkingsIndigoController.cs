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
        private readonly IParkingRepository _repository = null;

        public List<Parking> _parkings = new List<Parking>();

        public ParkingsIndigoController(IParkingRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //var model = Enumerable.Range(1, 10).Select(item => new Parking());

            var _parkings = this._repository.GetAll().ToList();
            this.ViewBag.parkings = _parkings;

            return View("Views/Parkings/Indigo/ParkingsIndigo.cshtml");
            //_parkings = query.ToList();
            //return this.Ok(query.ToList());
        }
    }
}
