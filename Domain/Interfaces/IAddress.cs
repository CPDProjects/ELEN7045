using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IAddress
    {
         int Id { get; set; }
         string Number { get; set; }
         string Street { get; set; }
         string Surburb { get; set; }
         string Town { get; set; }
         string City { get; set; }
         string Province { get; set; }
         string Country { get; set; }
         string Region { get; set; }
         string NearestCorner { get; set; }
         string GpsCoordinates { get; set; }
    }
}
