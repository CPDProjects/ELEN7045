using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FaultFactory 
    {
        private FaultRepository repository = new FaultRepository();
        
        public FaultFactory()
        {
            
        }
        public IFault CreateFault(string faultIdRef, string type, IAddress address, string description, IUser faultOperator)
        {
            FaultCategory faultType= FaultCategory.Accident;
            switch (type.ToLower())
            {
                case "trafficLight":
                    faultType=FaultCategory.TrafficLight;
                    break;
                case "drainage":
                    faultType = FaultCategory.Drainage;
                    break;
                case "pothole":
                    faultType = FaultCategory.Pothole;
                    break;
                case "roadmarking":
                    faultType = FaultCategory.RoadMarking;
                    break;
                case "signage":
                    faultType = FaultCategory.Signage;
                    break;
            };

            if (string.IsNullOrWhiteSpace(faultIdRef))
                faultIdRef = Guid.NewGuid().ToString();

            IFault aggregateEntity = new Fault {
                FaultIdReference= faultIdRef,
                Address = address,
                Description = description,
                Priority = CallCentrePriority.Low,
                FaultOperator =faultOperator,
                Type = faultType
            };

            aggregateEntity.Id= repository.Create(aggregateEntity);
            
            return aggregateEntity;
        }
    }
}
