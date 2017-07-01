using System;
using TechTalk.SpecFlow;

namespace BehaviouralDrivenDesign
{
    [Binding]
    public class FaultVerification_FileReportCardSteps
    {
        [Given(@"investigator finds a random '(.*)' enroute to fault location")]
        public void GivenInvestigatorFindsARandomEnrouteToFaultLocation(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"an investigator does not find a match from search list of faults based on '(.*)' already logged")]
        public void WhenAnInvestigatorDoesNotFindAMatchFromSearchListOfBasedOnAlreadyLogged(string faultBeingLoggedLocation)
        {
             
        }
        
        [Then(@"an investigator must complete '(.*)' using '(.*)'")]
        public void ThenAnInvestigatorMustCompleteUsing(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"create new fault and flag it as '(.*)'\.")]
        public void ThenCreateNewFaultAndFlagItAs_(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
