Feature: S_CreateWorkPlan
I create CompleteWork

@CompleteWork
Scenario: I create CreateWorkPlan
	Given I navigate to application and login as Rukovoditel
	When I create WorkPlan
	Then I should see that WorkPlank is created