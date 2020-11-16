Feature: Q_AcceptPhaseTP
I complete AcceptPhaseTP

@AppointDirector
Scenario: I complete AcceptPhaseTP
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I complete TechnicalProject
	Then I should see that TechnicalProject is complete
	When I click logout
	And I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I complete AcceptPhaseTP
	Then I should see that AcceptPhaseTP is complete