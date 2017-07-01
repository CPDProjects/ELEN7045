Feature: FaultLogging
	Provided the fault operator is available
	when road user logs a fault
	fault details must be captured in the system

@fault-logging
Scenario: Member of public logs a fault with call operator
	Given call-centre 'operator' is available
	When a member of public (customer) calls in and reports a fault
	Then issue a unique fault identification number
	And capture 'Accident', 'streetNo' , 'streetName' , 'suburb', 'city' , 'description' and 'priority'
	And operator must use street address to determine the gps co-ordinates 'logintude' and 'latitude'
	And system must list nearby faults (in-progress and closed) for the last month
	And if match found operator must flag fault as duplicate and inform client accordingly


