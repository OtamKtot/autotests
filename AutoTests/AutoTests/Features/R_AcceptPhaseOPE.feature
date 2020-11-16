Feature: R_AcceptPhaseOPE
I complete AcceptPhaseOPE

@AcceptPhaseOPE
Scenario: I complete AcceptPhaseOPE
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I complete PreparationOPE
	Then I should see that PreparationOPE is complete
	When I click logout
	And I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I complete AcceptPhaseOPE
	Then I should see that AcceptPhaseOPE is complete