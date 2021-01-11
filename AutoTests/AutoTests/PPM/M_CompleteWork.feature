Feature: M_CompleteWork
I complete CompleteWork

@CompleteWork
Scenario: I complete CompleteWork
	Given I navigate to application and login as Ispolnitel
	When I complete all tasks of Work
	Then I should see that all tasks of Work is completed