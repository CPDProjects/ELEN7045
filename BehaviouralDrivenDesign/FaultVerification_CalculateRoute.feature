Feature: FaultVerification_CalculateRoute
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@fault-verification
Scenario: Determine route for fault-investigator based on device location 
	Given fault-investigator is in a correct area 'jurisdiction' 
	When mobile  'device-location' aware and area of jurisdiction is 'confirmed'
	Then system must list nearby 'faults' in order by highest to lowest priority
	And calculate each 'fault-route' based on mobile device location and fault 'target-location'
	And display fault 'location-points' in a map format showing priority



