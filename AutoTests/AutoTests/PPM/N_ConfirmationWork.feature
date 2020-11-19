Feature: N_ConfirmationWork
I confirmation ConfirmationWork

@ConfirmationWork
Scenario: I confirmation ConfirmationWork
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I confirmation all tasks of Work
	Then I should see that all tasks of Work is confirmation