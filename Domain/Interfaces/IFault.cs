using System;

namespace Domain
{
    public interface IFault
    {
        IAddress Address { get; set; }
        DateTime DateClosed { get; }
        DateTime DateLogged { get; }
        DateTime DateModified { get; }
        string Description { get; set; }
        string FaultIdReference { get; set; }
        GpsCoordinates GpsCoordinates { get; set; }
        int Id { get; set; }
        IUser FaultOperator { get; }
        CallCentrePriority Priority { get; set; }
        IReportCard ReportCard { get; }
        FaultStatus Status { get; }
        FaultCategory Type { get; set; }
        IWorkOrder[] WorkOrders { get; }
        IWorkOrder getActiveWorkOrder();

        bool AttachReportCard(IReportCard reportCard);
        bool AttachWorkOrder(IWorkOrder workOrder);
        void CalculateGpsCoordinates(string location);
    }
}