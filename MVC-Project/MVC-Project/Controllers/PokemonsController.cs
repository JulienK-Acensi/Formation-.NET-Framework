using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Core.Domain;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        //[HttpGet]
        //public IEnumerable<Pokemon> Get()
        //{
        //    return Enumerable.Range(1, 10).Select(item => new Pokemon() { Id = item });
        //}

        [HttpGet]
        public IActionResult Get()
        {
            var model = Enumerable.Range(1, 10).Select(item => new Pokemon() { Id = item });

            //return this.StatusCode(StatusCodes.Status404NotFound);
            return this.Ok(model);
        }
    }
}
