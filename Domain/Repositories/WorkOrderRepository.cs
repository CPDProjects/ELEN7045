using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkOrderRepository
    {
        string dbConnection;

        private List<IWorkOrder> storeWorkOrder = null;
        private GenericRepository<WorkEquipment> repoEquipment;
        private GenericRepository<WorkMaterial> repoMaterial;
        private GenericRepository<RepairTeam> repoRepairTeam;


        public WorkOrderRepository(string dbConnection)
        {
            this.dbConnection = dbConnection;
            storeWorkOrder = new List<IWorkOrder>();
            repoEquipment = new GenericRepository<WorkEquipment>(dbConnection);
            repoMaterial = new GenericRepository<WorkMaterial>(dbConnection);
            repoRepairTeam = new GenericRepository<RepairTeam>(dbConnection);

        }
        public IWorkOrder[] GetAll()
        {
            return storeWorkOrder.ToArray();
        }

        public int Save(IWorkOrder workOrder)
        {
            //if (storeWorkOrder.Exists(f => workOrder.WorkOrderReference.Equals(f.WorkOrderReference)))
              //  return -1;
            storeWorkOrder.Add(workOrder);
            return storeWorkOrder.Count();
        }

        public IWorkOrder RetrieveByUsername(string workOrderReference)
        {
            return storeWorkOrder.FirstOrDefault(f => f.WorkOrderReference.Equals(workOrderReference));
        }

        public IWorkOrder RetrieveById(int id)
        {
            return storeWorkOrder.FirstOrDefault(f => f.Id.Equals(id));
        }

        public bool UpdateFault(IWorkOrder workOrder)
        {
            for (int c = 0; c < storeWorkOrder.Count(); c++)
                if (storeWorkOrder[c].Id.Equals(workOrder.Id))
                {
                    storeWorkOrder[c]=workOrder;
                    break;
                }

            return true;
        }

        public bool Delete(int id)
        {
            for (int c = 0; c < storeWorkOrder.Count(); c++)
                if (storeWorkOrder[c].Id.Equals(id))
                {
                    storeWorkOrder.Remove(storeWorkOrder[c]);
                    break;
                }

            return true;
        }
    }
}
