using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkOrderFactory
    {
        private string dbConnection;
        private WorkOrderRepository repoWorkOrder;

        public WorkOrderFactory(string dbConnection)
        {
            this.dbConnection = dbConnection;
            repoWorkOrder = new WorkOrderRepository(dbConnection);
        }

        public IWorkOrder Create(string faultReferenceNo)
        {
            //TODO: validate fault reference no
            var workOrder = new WorkOrder (faultReferenceNo);
            workOrder.Status = WorkOderStatus.New;
            workOrder.WorkOrderReference = Guid.NewGuid().ToString();
            return workOrder;

        }
    }
}
