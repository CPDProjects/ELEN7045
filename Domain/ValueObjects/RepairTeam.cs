using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RepairTeam
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public User Memebers { get; set; }
        public User TeamLeader { get; set; }
        public Region Region { get; set; }
    }
}
