Feature: FaultLogging
	Provided the fault operator is available
	when road user logs a fault
	fault details must be captured in the system

@mytag
Scenario: Member of public logs a fault with call operator
	Given call-centre 'operator' is available
	When a member of public (customer) calls in and reports a fault
	Then issue a unique fault identification number
	And capture 'fault-type', 'streetNo' , 'streetName' , 'suburb', 'city' , 'description' and 'priority'
	And operator must use street address to determine the fault location
	And system must list nearby faults (in-progress and closed) for the last month
	And if match found operator must flag fault as duplicate and inform client accordingly

