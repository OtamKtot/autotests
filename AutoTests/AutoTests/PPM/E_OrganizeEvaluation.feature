Feature: E_OrganizeEvaluation
I complete OrganizeEvaluation

@TechnicalRequirements
Scenario: I complete OrganizeEvaluation
	Given I navigate to application and login as Project
	When I complete OrganizeEvaluation
	Then I should see that OrganizeEvaluation is complete