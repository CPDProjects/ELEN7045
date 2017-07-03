using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RepairTeam: IModel
    {
        public int Id { get; set; }
        public virtual string Description { get; set; }
        public IUser[] Memebers { get; set; }
        public IUser TeamLeader { get; set; }
        public virtual Region Region { get; set; }
        public string ReferenceNo { get; set; }
        public virtual RepairTeamStatus Status { get; set; }

    }
}
