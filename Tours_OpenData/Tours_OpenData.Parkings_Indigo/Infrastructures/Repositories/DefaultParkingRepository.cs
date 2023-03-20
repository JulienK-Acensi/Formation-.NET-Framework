using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours_OpenData.Parkings_Indigo.Domain;
using Tours_OpenData.Parkings_Indigo.Infrastructures.Contexts;

namespace Tours_OpenData.Parkings_Indigo.Infrastructures.Repositories
{
    public class DefaultParkingRepository : IParkingRepository
    {
        private ParkingContext _context;

        public DefaultParkingRepository(ParkingContext context) 
        {
            _context = context;
        }
        public ICollection<Parking> GetAll()
        {
            return this._context.Parkings.ToList();
        }
    }
}
