Feature: Q_AcceptPhaseTP
I complete AcceptPhaseTP

@AppointDirector
Scenario: I complete AcceptPhaseTP
	Given I navigate to application and login as Rukovoditel
	Given I complete TechnicalProject
	Given I click logout
	Given I navigate to application and login as Project
	When I complete AcceptPhaseTP
	Then I should see that AcceptPhaseTP is completed