using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_OpenData.Parkings_Indigo.Domain
{
    public interface IParkingRepository
    {
        ICollection<Parking> GetAll();
    }
}
