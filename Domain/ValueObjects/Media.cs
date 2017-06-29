using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public byte[] MediaObject { get; set; }
        public MediaType Type { get; set; }
        
    }
}
