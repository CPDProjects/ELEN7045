using System;
using TechTalk.SpecFlow;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BehaviouralDrivenDesign
{
    [Binding]
    public class FaultLoggingSteps
    {
        private string callCenterOperator;
        [Given(@"call-centre '(.*)' is available")]
        public void GivenCall_CentreOperatorIsAvailable(string ccOperator)
        {
            callCenterOperator = ccOperator;
        }

        private bool isInComingCall=false;
        [When(@"a member of public \(customer\) calls in and reports a fault")]
        public void WhenAMemberOfPublicCustomerCallsInAndReportsAFault()
        {
            isInComingCall = true;
        }

        private FaultService faultService;
        private string uniqueFaultIdentifier = string.Empty;
        [Then(@"issue a unique fault identification number")]
        public void ThenIssueAUniqueFaultIdentificationNumber()
        {
            if (faultService == null)
                faultService = new FaultService(new FaultRepository(""));
            uniqueFaultIdentifier = faultService.IssueNewFaultIdentifier();
            
        }

        private int expectedResult = 1;
        private FaultRepository faultRepository = new FaultRepository("");
        private FaultFactory faultFactory = null;
        private IFault fault;

        [Then(@"capture address '(.*)', '(.*)' , '(.*)' , '(.*)', '(.*)' , '(.*)' and '(.*)'")]
        public void ThenCaptureFault_TypeStreetNoStreetNameSuburbCityDescriptionAndPriority(string faulType,string streetNo, 
            string streetName, string suburb, string city, string description, string priority)
        {
         
            //TDD #1 - Write a failing test
            //Assert.AreEqual(expectedResult, -11);
            
            //TDD #2 - Pass the test
            //Assert.AreEqual(expectedResult, 1);

            //TDD #3 - Refactor with business logic with our Domain models 
            faultFactory = new FaultFactory("");
            fault = faultFactory.CreateFault(uniqueFaultIdentifier, faulType, streetNo,
            streetName,  suburb, city, description, callCenterOperator);
            Assert.AreEqual(expectedResult, fault.Id);

        }

        private RouteService routeService;
        [Then(@"fault-operator must use street address '(.*)' to determine the fault location '(.*)' and '(.*)'")]
        public void ThenOperatorMustUseStreetAddressToDetermineTheFaultLocation(string streetAddress,
            string longitude, string latitude)
        {
            var gpsCoOrdinates = new GpsCoordinates(streetAddress);
            Assert.AreEqual(gpsCoOrdinates.Latitude, latitude);
            Assert.AreEqual(gpsCoOrdinates.Longitude, longitude);
        }
        
        [Then(@"system must list nearby faults \(in-progress and closed\) for the last month")]
        public void ThenSystemMustListNearbyFaultsIn_ProgressAndClosedForTheLastMonth()
        {
            //
        }
        
        [Then(@"if match found operator must flag fault as duplicate and inform client accordingly")]
        public void ThenIfMatchFoundOperatorMustFlagFaultAsDuplicateAndInformClientAccordingly()
        {
            //
        }
    }
}
