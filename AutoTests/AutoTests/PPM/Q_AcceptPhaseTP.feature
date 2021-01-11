Feature: Q_AcceptPhaseTP
I complete AcceptPhaseTP

@AppointDirector
Scenario: I complete AcceptPhaseTP
	Given I navigate to application and login as Rukovoditel
	When I complete TechnicalProject
	Then I should see that TechnicalProject is completed
	When I click logout
	Given I navigate to application and login as Project
	When I complete AcceptPhaseTP
	Then I should see that AcceptPhaseTP is completed