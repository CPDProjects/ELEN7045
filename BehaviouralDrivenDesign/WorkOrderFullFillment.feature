Feature: WorkOrderFullFillment
	WorkOrder Fullfillment Feature

@mytag

Scenario: Repair team leader will download scheduled work-orders, navigate to fault sites and update completed tasks.
	Given team-leader has downloaded all scheduled work-orders on the mobile device
	When team-leader has navigated to fault site
	Then team leader must review tasks and equipment 
	And update completed tasks when repair work is done
