Feature: S_CreateWorkPlan
I create CompleteWork

@CompleteWork
Scenario: I create CreateWorkPlan
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I create WorkPlan
	Then I should see that WorkPlank is create