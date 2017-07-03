using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FaultService
    {
        private FaultRepository faultRepository;
        public FaultService(FaultRepository repository)
        {
            this.faultRepository = repository;

        }

        public FaultService() { }

        public virtual IFault[] FindFaultByLocation(string streetAddress)
        {
            return faultRepository.GetAll().Where(f=>f.Address.ToString().Equals(streetAddress)).ToArray();
        }

        public virtual string IssueNewFaultIdentifier()
        {
            return Guid.NewGuid().ToString();
        }

        
    }
}
