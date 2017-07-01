using System;

namespace Domain
{
    public interface IWorkOrder
    {
        WorkOrderActivity[] Activities { get; set; }
        DateTime DateCreated { get; set; }
        WorkEquipment[] Equipment { get; set; }
        DateTime ExecutionDateCompleted { get; set; }
        DateTime ExecutionDateScheduled { get; set; }
        int Id { get; set; }
        string FaultReferenceNo { get; }
        WorkMaterial[] Material { get; set; }
        RepairTeam[] RepairTeams { get;}
        WorkOderStatus Status { get; set; }
        string WorkOrderReference { get; set; }
        void AssignRepairTeam(RepairTeam team);
    }
}