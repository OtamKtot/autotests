Feature: N_ConfirmationWork
I confirmation ConfirmationWork

@ConfirmationWork
Scenario: I confirmation ConfirmationWork
	Given I navigate to application and login as Rukovoditel
	When I confirmation all tasks of Work
	Then I should see that all tasks of Work is confirmation