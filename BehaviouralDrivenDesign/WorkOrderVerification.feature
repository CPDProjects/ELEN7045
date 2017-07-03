Feature: WorkOrderVerification
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Supervisor should be able extract all faults flagged as completed review tasks completed against faults logged. If satisfied sign-off on work-orders, if unsatisfied attach a new work-order to rectify or schedule field-inspection work-order.
	Given supervisor has an extract of all work-orders completed
	When supervisor reviews tasks done against fault details logged
	Then supervisor can sign-off on work-order if 'satisfied' 
	Or attach new work-order with status of 'awaiting-schedule'
	Or attach a new work-order with status of 'field-inspection'

