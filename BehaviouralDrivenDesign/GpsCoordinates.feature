Feature: GpsCoordinates
	calculate Gps Co-ordinates in the background when operator captures the street address

@gps-coordinates

Scenario: GPS location is calculated in the background when street address is captured
	Given call-centre 'ccOperator' is busy capturing fault details
	When street address details have been captured 'Accident', '22' , 'Oxford street' , 'parktown', 'johannesburg' , 'accident' and 'low'
	Then system calculate GpsCoordinates  '-26.0965791', '27.987855399999997' of the fault location