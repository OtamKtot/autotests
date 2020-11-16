Feature: C_TechnicalRequirements
I complete TechnicalRequirements

@TechnicalRequirements
Scenario: I complete TechnicalRequirements
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I complete TechnicalRequirements
	Then I should see that TechnicalRequirements is complete