using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkOrder : IWorkOrder
    {
        
        public WorkOrder(string faultRef)
        {
            this.faultRef = faultRef;
            repairTeams = new List<RepairTeam>();
        }
        public int Id { get; set; }
        public string WorkOrderReference { get; set; }
        private string faultRef;
        public string FaultReferenceNo { get { return faultRef; } }
        public WorkOrderActivity[] Activities {get;set;}
        public WorkMaterial[] Material { get; set; }
        public WorkEquipment[] Equipment { get; set; }
        public WorkOderStatus Status { get; set; }
        private List<RepairTeam> repairTeams;
        public RepairTeam[] RepairTeams { get { return repairTeams.ToArray(); } }
        public DateTime DateCreated { get; set; }
        public DateTime ExecutionDateScheduled { get; set; }
        public DateTime ExecutionDateCompleted { get; set; }

        public void AssignRepairTeam(RepairTeam team)
        {
            //TODO validate team locatino against fault location and fault type
            this.repairTeams.Add(team);
        }

    }
}
