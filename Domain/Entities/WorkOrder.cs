using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkOrder : IWorkOrder
    {
        public int Id { get; set; }
        public string WorkOrderReference { get; set; }
        public WorkOrderActivity[] Activities {get;set;}
        public WorkMaterial[] Material { get; set; }
        public WorkEquipment[] Equipment { get; set; }
        public WorkOderStatus Status { get; set; }
        public RepairTeam[] RepairTeam { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ExecutionDateScheduled { get; set; }
        public DateTime ExecutionDateCompleted { get; set; }

    }
}
