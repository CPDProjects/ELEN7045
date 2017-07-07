using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkOrderSchedulerService
    {
        public virtual IWorkOrder FindWorkOrder(string streetAddress,String repairTeamLocation, List<IWorkOrder> workOrderList)
        {
            return null;
        }

        public void AssignWorkOrder(IWorkOrder workOrder, RepairTeam repairTeam)
        {
            workOrder.AssignRepairTeam(repairTeam);
        }
    }

    
}
