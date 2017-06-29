using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Fault : IFault
    {
        public int Id { get; set; }
        public string FaultIdReference { get; set; }
        public FaultCategory Type { get; set; }
        public IAddress Address { get; set; }
        public GpsCoordinates GpsCoordinates { get; set; }
        public string Description { get; set; }        
        public CallCentrePriority Priority { get; set; }
        public FaultStatus Status { get; }
        public DateTime DateLogged { get;  }
        public DateTime DateModified { get; }
        public DateTime DateClosed { get; }
        public IUser FaultOperator { get; set; }
        public IWorkOrder[] WorkOrders { get; }
        public IReportCard ReportCard { get; }

        public Address Address1
        {
            get => default(Address);
            set
            {
            }
        }

        public void CalculateGpsCoordinates(string location)
        {
            
        }

        public bool AttachWorkOrder(IWorkOrder workOrder)
        {
            return false;
        }

        public bool AttachReportCard(IReportCard reportCard)
        {
            return false;
        }
        
    }
}
