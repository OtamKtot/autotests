Feature: R_AcceptPhaseOPE
I complete AcceptPhaseOPE

@AcceptPhaseOPE
Scenario: I complete AcceptPhaseOPE
	Given I navigate to application and login as Rukovoditel
	Given I complete PreparationOPE
	Given I click logout
	Given I navigate to application and login as Rukovoditel
	When I complete AcceptPhaseOPE
	Then I should see that AcceptPhaseOPE is completed