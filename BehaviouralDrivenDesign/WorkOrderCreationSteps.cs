using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Domain;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BehaviouralDrivenDesign
{
    [Binding]
    public class WorkOrderCreationSteps
    {
        private Mock<IFault> faultMock = new Mock<IFault>();
        IFault fault;
        private WorkOrderFactory factoryWorkOrder;
        private WorkOrderRepository repositoryWorkOrder;
        IWorkOrder workOrder;            

        [Given(@"fault-investigator has verified a fault \('(.*)'\)")]
        public void GivenFault_InvestigatorHasVerifiedAFault(string faultStatus)
        {
            
            //moq fault state
            faultMock.Setup(f => f.Status).Returns(FaultStatus.Verified);
            fault = faultMock.Object;
            Assert.AreEqual(fault.Status.ToString().ToLower(), faultStatus.ToLower());
        }
        
        [When(@"work-order-manager creates a new work-order and assign to fault with '(.*)' status")]
        public void WhenWork_Order_ManagerCreatesANewWork_OrderAndAssignToFault(string workOrderStatus)
        {
            factoryWorkOrder = new WorkOrderFactory();
            workOrder = factoryWorkOrder.Create(fault.FaultIdReference);
            Assert.IsNotNull(workOrder);
            Assert.AreEqual(workOrder.Status.ToString().ToLower(), workOrderStatus.ToLower());
            repositoryWorkOrder.Save(workOrder);
            fault.AttachWorkOrder(workOrder);
        }

        private WorkOrderService workService;
        [Then(@"new bill-of-material must be assigned to work-order")]
        public void ThenNewBill_Of_MaterialMustBeAssignedToWork_Order()
        {
            workService = new WorkOrderService();
           var material =  workService.GetWorkMaterial(fault.Type.ToString());
            workOrder.Material = material;
            
        }
        
        [Then(@"required equipment must be assigned to work-order")]
        public void ThenRequiredEquipmentMustBeAssignedToWork_Order()
        {
            workService = new WorkOrderService();
            var equipment = workService.GetWorkEquipment(fault.Type.ToString());
            workOrder.Equipment = equipment;
        }
        
        [Then(@"work-order-status status must be set to \('(.*)'\)")]
        public void ThenWork_Order_StatusStatusMustBeSetTo(string workOrderStatus)
        {
            workOrder.Status = WorkOderStatus.QueuedForScheduling;
            Assert.AreEqual(workOrder.Status.ToString(), workOrderStatus);
        }
    }
}
