using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AuditEntry
    {
        public int Id { get; set; }
        public string ActionType { get; set; }
        public string Comment { get; set; }
        public User User { get; set; }
        public Fault Fault { get; set; }
        public DateTime DateTimeStamp { get; set; }
    }
}
