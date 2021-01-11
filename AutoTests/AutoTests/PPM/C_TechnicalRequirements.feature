Feature: C_TechnicalRequirements
I complete TechnicalRequirements

@TechnicalRequirements
Scenario: I complete TechnicalRequirements
	Given I navigate to application and login as Project
	When I complete TechnicalRequirements
	Then I should see that TechnicalRequirements is completed