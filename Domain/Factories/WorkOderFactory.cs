using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkOrderFactory
    {

        public IWorkOrder Create(string faultReferenceNo)
        {
            /*if(string.IsNullOrEmpty(faultReferenceNo))
            {
                throw new WorkOrderCreationException("faultReferenceNo is missing");
            }*/

            var workOrder = new WorkOrder (faultReferenceNo);
            workOrder.Status = WorkOderStatus.New;
            workOrder.WorkOrderReference = Guid.NewGuid().ToString();
            return workOrder;

        }
    }
}
