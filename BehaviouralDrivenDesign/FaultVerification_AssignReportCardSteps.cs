using System;
using TechTalk.SpecFlow;
using Moq;
using Domain;

namespace BehaviouralDrivenDesign
{
    [Binding]
    public class FaultVerification_AssignReportCardSteps
    {
        [Given(@"fault-investigator has identified a fault")]
        public void GivenFault_InvestigatorHasIdentifiedAFault()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"an investigator picks up the '(.*)' from system, confirms the fault-type and confirms that fault does exists")]
        public void WhenAnInvestigatorPicksUpTheFromSystemConfirmsTheFault_TypeAndConfirmsThatFaultDoesExists(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"system must generate a '(.*)' and display a set of questions associated with fault type")]
        public void ThenSystemMustGenerateAAndDisplayASetOfQuestionsAssociatedWithFaultType(string faultType)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"investigator must complete report card and '(.*)'")]
        public void ThenInvestigatorMustCompleteReportCardAnd(string faultIdRef)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"fault is flagged as '(.*)'")]
        public void ThenFaultIsFlaggedAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
