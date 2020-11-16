Feature: D_RateUrgency
I complete RateUrgency

@TechnicalRequirements
Scenario: I complete RateUrgency
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I complete RateUrgency
	Then I should see that RateUrgency is complete