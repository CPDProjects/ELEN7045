using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Address:IAddress
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Surburb { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string NearestCorner { get; set; }
        public string GpsCoordinates { get; set; }

        public override string ToString()
        {
            return string.Concat(Number, " ", Street, " ", Surburb, " ", Town, " ", City, " ", Province, " ", Country);
        }

    }
}
