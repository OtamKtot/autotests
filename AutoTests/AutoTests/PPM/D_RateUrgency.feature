Feature: D_RateUrgency
I complete RateUrgency

@TechnicalRequirements
Scenario: I complete RateUrgency
	Given I navigate to application and login as Project
	When I complete RateUrgency
	Then I should see that RateUrgency is completed