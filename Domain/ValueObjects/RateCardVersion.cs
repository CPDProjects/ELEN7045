using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RateCardVersion
    {
        public int Id { get; set; }
        public Guid VersionNumber { get; set; }
        public string VersionReference { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
