﻿using System.Collections.Generic;
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
        IWorkOrder workOrder;
        RepairTeam repairTeam;
        WorkOrderSchedulerService schedulingService;
        
        List<IWorkOrder> workOrderList = new List<IWorkOrder>();

        public WorkOrderSchedulingSteps()
        {
            TestSetup();
        }

        private void TestSetup()
        {
            var mockTeam = new Mock<RepairTeam>();
            mockTeam.Setup(t => t.Region).Returns(new Region { Address = "test", GpsLocation = new GpsCoordinates("test") });
            mockTeam.Setup(t => t.Status).Returns(RepairTeamStatus.Available);
            mockTeam.Setup(t => t.Description).Returns("test");
            repairTeam = mockTeam.Object;
            

        }

        [Given(@"there is a work-order in '(.*)' status")]
        public void GivenThereIsAWork_OrderInStatus(string workOrderStatus)
        {   
            IWorkOrder workOrderA = new WorkOrderFactory().Create("123");
            workOrderA.Status = WorkOderStatus.QueuedForScheduling;
            workOrderList.Add(workOrderA);

            IWorkOrder workOrderB = new WorkOrderFactory().Create("234");
            workOrderB.Status = WorkOderStatus.QueuedForScheduling;
            workOrderList.Add(workOrderB);

            IWorkOrder workOrderC = new WorkOrderFactory().Create("345");
            workOrderC.Status = WorkOderStatus.QueuedForScheduling;
            workOrderList.Add(workOrderC);
            Assert.IsNotNull(workOrderList);

        }
        
        [When(@"dispatcher finds repair-team that is available and matches repair-team location to a fault-location")]
        public void WhenDispatcherFindsRepair_TeamThatIsAvailableAndMatchesRepair_TeamLocationToAFault_Location()
        {
            var mockSchedulingSvc = new Mock<WorkOrderSchedulerService>();
            mockSchedulingSvc.Setup(s => s.FindWorkOrder("locationA", "locationA", workOrderList)).Returns(new WorkOrder("123"));
            schedulingService = mockSchedulingSvc.Object;

            workOrder = schedulingService.FindWorkOrder("locationA", "locationA", workOrderList);
            Assert.IsNotNull(workOrder);
            mockSchedulingSvc.Verify();
        }
        
        [Then(@"work-order must be allocated to that matching repair-team (.*)")]
        public void ThenWork_OrderMustBeAllocatedToThatMatchingRepair_Team(string repairTeamName)
        {
            WorkOrderSchedulerService workOrderSchedulerService = new WorkOrderSchedulerService();
            workOrderSchedulerService.AssignWorkOrder(workOrder, repairTeam);
            Assert.IsNotNull(workOrder.RepairTeams);
        }
    }
}
