using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkOrderService
    {
                
        public WorkOrderService()
        {

        }

        public WorkMaterial[] GetWorkMaterial(string faultType)
        {
            var material = new List<WorkMaterial> { new WorkMaterial { Description = "test" } };
            return material.ToArray();
        }

        public WorkEquipment[] GetWorkEquipment(string faultType)
        {
            var equipment = new List<WorkEquipment> { new WorkEquipment { Description = "test" } };
            return equipment.ToArray();
        }


    }
}
