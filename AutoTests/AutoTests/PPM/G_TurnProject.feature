Feature: G_TurnProject
I complete TurnProject

@TechnicalRequirements
Scenario: I complete TurnProject
	Given I navigate to application and login as Project
	When I complete TurnProject
	Then I should see that TurnProject is complete