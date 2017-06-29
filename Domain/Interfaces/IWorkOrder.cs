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
        WorkMaterial[] Material { get; set; }
        RepairTeam[] RepairTeam { get; set; }
        WorkOderStatus Status { get; set; }
        string WorkOrderReference { get; set; }
    }
}