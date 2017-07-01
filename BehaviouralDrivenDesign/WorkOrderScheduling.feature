Feature: WorkOrderScheduling
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: WorkOrder dispatcher must allocate tasks to a repair team based on proximity and team availability
	Given there is a work-order in 'awaiting-schedule' status
	When dispatcher finds repair-team that is available and matches repair-team location to a fault-location
	Then work-order must be allocated to that matching repair-team
