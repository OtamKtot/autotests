Feature: H_AppointDirector
I complete AppointDirector

@AppointDirector
Scenario: I complete AppointDirector
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Director    | 1   |
	And I click login
	And I complete AppointDirector
	Then I should see that AppointDirector is complete