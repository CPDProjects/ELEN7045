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
        private SecurityRepository securityRepo = new SecurityRepository("");
        
        public FaultFactory()
        {
            
        }
        public IFault CreateFault(string faultIdRef, string type, string streetNo,
            string streetName, string suburb, string city, string description, string userName)
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

            var address = new Address
            {
                City = city,
                Number = streetNo,
                Street = streetName,
                Surburb = suburb
            };

            if (string.IsNullOrWhiteSpace(faultIdRef))
                faultIdRef = Guid.NewGuid().ToString();
            var faultOperator = securityRepo.GetAll().FirstOrDefault(u => u.UserName.Equals(userName));

            IFault aggregateEntity = new Fault {
                FaultIdReference= faultIdRef,
                Address = address,
                Description = description,
                Priority = CallCentrePriority.Low,
                FaultOperator = faultOperator,
                Type = faultType
            };

            aggregateEntity.Id= repository.Create(aggregateEntity);
            
            return aggregateEntity;
        }

        
    }
}
