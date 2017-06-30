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

        public IWorkOrder Create()
        {
            var workOrder = new WorkOrder();

        }
    }
}
