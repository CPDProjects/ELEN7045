using System;
using TechTalk.SpecFlow;

namespace BehaviouralDrivenDesign
{
    [Binding]
    public class GpsCoordinatesSteps
    {
        [Given(@"call-centre '(.*)' is busy capturing fault details")]
        public void GivenCall_CentreIsBusyCapturingFaultDetails(string ccOperator)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"street address details have been captured '(.*)', '(.*)' , '(.*)' , '(.*)', '(.*)' , '(.*)' and '(.*)'")]
        public void WhenStreetAddressDetailsHaveBeenCapturedAnd(string faultType, string streetNo, string streetName, string suburb, string city, string description, string priority)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"system calculate '(.*)' of the fault location")]
        public void ThenSystemCalculateOfTheFaultLocation(string expectedLatitude, string expectedLongitude)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
