Feature: G_TurnProject
I complete TurnProject

@TechnicalRequirements
Scenario: I complete TurnProject
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I complete TurnProject
	Then I should see that TurnProject is complete