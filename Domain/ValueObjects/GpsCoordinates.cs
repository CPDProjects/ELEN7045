using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GpsCoordinates
    {
        string address;
        string longitude;
        string latitude;
        public GpsCoordinates(string address)
        {
            this.address = address;
        }
        public GpsCoordinates(string streetNo,
            string streetName, string suburb, string city)
        {
            address = $"{streetNo} {streetName}, {suburb}, {city}";
        }
        public string Address { get { return address; } }
        public string Latitude { get { return latitude; } }
        public string Longitude { get { return longitude; } }
    }
}
