using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkOrderActivity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ActivityInstruction[] Instructions { get; set; }
    }
}
