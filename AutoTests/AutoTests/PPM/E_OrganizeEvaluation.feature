Feature: E_OrganizeEvaluation
I complete OrganizeEvaluation

@TechnicalRequirements
Scenario: I complete OrganizeEvaluation
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I complete OrganizeEvaluation
	Then I should see that OrganizeEvaluation is complete