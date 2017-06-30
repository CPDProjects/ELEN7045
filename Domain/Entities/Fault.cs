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

        private List<IWorkOrder> _workOrders;
        public IWorkOrder[] WorkOrders { get { return _workOrders.ToArray(); } }

        private IReportCard _reportCard;
        public IReportCard ReportCard { get { return _reportCard; } }

        public Fault()
        {
            _workOrders = new List<IWorkOrder>();
        }

        
        
        public void CalculateGpsCoordinates(string location)
        {
            
        }

        public bool AttachWorkOrder(IWorkOrder workOrder)
        {
            //TODO validation
            _workOrders.Add(workOrder);
            return false;
        }
        

        public bool AttachReportCard(IReportCard reportCard)
        {
            //TODO validation
            _reportCard = reportCard;
            return true;
        }
        
    }
}
