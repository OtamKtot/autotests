Feature: M_CompleteWork
I complete CompleteWork

@CompleteWork
Scenario: I complete CompleteWork
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Ispolnitel    | 1   |
	And I click login
	And I complete all tasks of Work
	Then I should see that all tasks of Work is complete