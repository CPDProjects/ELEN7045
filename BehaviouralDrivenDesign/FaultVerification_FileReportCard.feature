Feature: FaultVerification_FileReportCard
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@fault-verification
Scenario: Investigator finds a fault, search nearby listed faults and files report card and verifies fault
	Given investigator finds a random 'fault' enroute to fault location
	When an investigator does not find a match from search list of 'nearby-faults' based on 'location' already logged
	Then an investigator must complete 'report-card' using 'Accident' 
	And create new fault and flag it as 'verified'.
