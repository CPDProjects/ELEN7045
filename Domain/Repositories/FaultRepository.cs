using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FaultRepository
    {
        //in-memory fault store
        private List<IFault> storeFaults = null;

        public FaultRepository()
        {
            storeFaults = new List<IFault>();
        }

        public Fault Fault
        {
            get => default(Fault);
            set
            {
            }
        }

        public IFault[] GetAll()
        {
            return storeFaults.ToArray();
        }

        public int Create(IFault fault)
        {
            if (storeFaults.Exists(f => fault.Description.Equals(f.Description)))
                return -1;
            fault.FaultIdReference = Guid.NewGuid().ToString();
            storeFaults.Add(fault);
            return storeFaults.Count();
        }

        public IFault RetrieveFaultByFaultIdRef(string faultIdRef)
        {
            return storeFaults.FirstOrDefault(f => f.FaultIdReference.Equals(faultIdRef));
                
        }

        public IFault RetrieveFaultById(int faultId)
        {
            return storeFaults.FirstOrDefault(f => f.Id.Equals(faultId));
        }

        public bool UpdateFault(IFault fault)
        {
            return true;
        }

        public bool DeleteFault(int faultId)
        {
            for (int c = 0; c < storeFaults.Count(); c++)
                if (storeFaults[c].Id.Equals(faultId))
                {
                    storeFaults.Remove(storeFaults[c]);
                    break;
                }
                    
            return true;
        }

    }
}
