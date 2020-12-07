Feature: P_AcceptPhaseCP
I complete AcceptPhaseCP

@AcceptPhaseCP
Scenario: I complete AcceptPhaseCP
	Given I navigate to application and login as Project
	When I complete AcceptPhaseCP
	Then I should see that AcceptPhaseCP is complete