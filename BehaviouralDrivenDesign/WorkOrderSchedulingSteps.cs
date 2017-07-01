using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Domain;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BehaviouralDrivenDesign
{
    [Binding]
    public class WorkOrderSchedulingSteps
    {
        Mock<IWorkOrder> mockWork;
        IWorkOrder workOrder;
        IFault fault;
        RepairTeam repairTeam;
        FaultService faultService;

        public WorkOrderSchedulingSteps()
        {
            TestSetup();
        }

        private void TestSetup()
        {
            var mockFault = new Mock<IFault>();
            mockFault.Setup(f => f.GpsCoordinates).Returns(new GpsCoordinates("test"));
            mockFault.Setup(f => f.WorkOrders).Returns(new[] { new WorkOrder("test") });
            fault = mockFault.Object;

            var mockTeam = new Mock<RepairTeam>();
            mockTeam.Setup(t => t.Region).Returns(new Region { Address = "test", GpsLocation = new GpsCoordinates("test") });
            mockTeam.Setup(t => t.Status).Returns(RepairTeamStatus.Available);
            mockTeam.Setup(t => t.Description).Returns("test");
            repairTeam = mockTeam.Object;

            var mockFaultSvc = new Mock<FaultService>();
            mockFaultSvc.Setup(s => s.FindFaultByLocation("test")).Returns(new[] { fault });
            faultService = mockFaultSvc.Object;

        }

        [Given(@"there is a work-order in '(.*)' status")]
        public void GivenThereIsAWork_OrderInStatus(string workOrderStatus)
        {
            mockWork = new Mock<IWorkOrder>();
            mockWork.Setup(w => w.Status).Returns(WorkOderStatus.QueuedForScheduling);            
            workOrder = mockWork.Object;
            Assert.AreEqual(workOrder.Status.ToString().ToLower(), workOrderStatus.ToLower());
            
        }
        
        [When(@"dispatcher finds repair-team that is available and matches repair-team location to a fault-location")]
        public void WhenDispatcherFindsRepair_TeamThatIsAvailableAndMatchesRepair_TeamLocationToAFault_Location()
        {
            var nearByFaults = faultService.FindFaultByLocation("test");

            Assert.AreEqual(nearByFaults[0].Address.GpsCoordinates, repairTeam.Region.GpsLocation);
                
        }
        
        [Then(@"work-order must be allocated to that matching repair-team (.*)")]
        public void ThenWork_OrderMustBeAllocatedToThatMatchingRepair_Team(string repairTeamName)
        {
            workOrder.AssignRepairTeam(repairTeam);
            Assert.AreEqual(workOrder.RepairTeams[0].Description, repairTeamName);
        }
    }
}
