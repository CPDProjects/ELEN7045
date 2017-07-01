using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RouteService
    {

        public Route CalculateRoute(string fromLocation,string targetLocation)
        {
            return new Route
            {
                FromLocation = new GpsCoordinates(fromLocation),
                TargetLocation = new GpsCoordinates(targetLocation)
            };
        }

        
    }
}
