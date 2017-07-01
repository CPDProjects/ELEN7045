using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Route
    {
        public GpsCoordinates FromLocation { get; set; }
        public GpsCoordinates TargetLocation { get; set; }
    }
}
