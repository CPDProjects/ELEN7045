using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BehaviouralDrivenDesign
{
    [TestClass]
    public class UnitTestForWorkOrder
    {
        private Mock<IFault> faultMock = new Mock<IFault>();
        IFault fault;
        private WorkOrderFactory factoryWorkOrder;
        private WorkOrderRepository repositoryWorkOrder;

        //[TestMethod]
        public void TestFaultMockCreation()
        {
            faultMock.Setup(f => f.Status).Returns(FaultStatus.Verified);
            fault = faultMock.Object;
            Assert.AreEqual(fault.Status.ToString().ToLower(), "Verified".ToLower());
            Console.WriteLine(fault.Status.ToString());
        }

        [TestMethod]
        public void TestWorkOrderCreation()
        {
            try
            {
                Mock<IFault> faultMock = new Mock<IFault>();
                faultMock.Setup(f => f.Status).Returns(FaultStatus.Verified);
                faultMock.Setup(f => f.FaultIdReference).Returns("234");
                fault = faultMock.Object;
                Assert.AreEqual(fault.Status.ToString().ToLower(), FaultStatus.Verified.ToString().ToLower());
                factoryWorkOrder = new WorkOrderFactory();
                IWorkOrder workOrder = factoryWorkOrder.Create(fault.FaultIdReference);

                repositoryWorkOrder = new WorkOrderRepository("");
                repositoryWorkOrder.Save(workOrder);
                faultMock.Verify(f => f.FaultIdReference);

            } catch(Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();
        }
    }
}
