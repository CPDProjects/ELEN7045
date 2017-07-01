Feature: FaultVerification_AssignReportCard
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@fault-verification
Scenario: fault-investigator must verify fault type using report card 
	Given 'fault-investigator has identified a fault
	When an investigator picks up the 'Accident' from system, confirms the fault-type and confirms that fault does exists
	Then system must generate a 'report-card' and display a set of questions associated with fault type
	And investigator must complete report card and 'upload/submit'
	And fault is flagged as 'verified'