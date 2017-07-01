using System;
using TechTalk.SpecFlow;

namespace BehaviouralDrivenDesign
{
    [Binding]
    public class FaultVerification_CalculateRouteSteps
    {
        [Given(@"fault-investigator is in a correct area '(.*)'")]
        public void GivenFault_InvestigatorIsInACorrectArea(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"mobile  '(.*)' aware and area of jurisdiction is '(.*)'")]
        public void WhenMobileAwareAndAreaOfJurisdictionIs(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"system must list nearby '(.*)' in order by highest to lowest priority")]
        public void ThenSystemMustListNearbyInOrderByHighestToLowestPriority(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"calculate each '(.*)' based on mobile device location and fault '(.*)'")]
        public void ThenCalculateEachBasedOnMobileDeviceLocationAndFault(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"display fault '(.*)' in a map format showing priority")]
        public void ThenDisplayFaultInAMapFormatShowingPriority(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
