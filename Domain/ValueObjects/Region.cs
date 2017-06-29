using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Region
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public GpsCoordinates GpsLocation { get; set; }
    }
}
