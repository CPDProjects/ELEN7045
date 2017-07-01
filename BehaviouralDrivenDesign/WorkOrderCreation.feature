Feature: WorkOrderCreation
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@WorkOrder Creation Feature
Scenario: Create a new WorkOrder by assigning Tasks that include bill of material and equipment 
	Given fault-investigator ('investigator') has verified a fault
	When work-order-manager creates a new work-order and assign to fault with work-status 'new'
	Then new bill-of-material must be assigned to work-order
	And required equipment must be assigned to work-order
	And work-order-status status must be set to ('QueuedForScheduling')

