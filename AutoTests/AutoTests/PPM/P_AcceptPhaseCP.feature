Feature: P_AcceptPhaseCP
I complete AcceptPhaseCP

@AcceptPhaseCP
Scenario: I complete AcceptPhaseCP
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I complete AcceptPhaseCP
	Then I should see that AcceptPhaseCP is complete