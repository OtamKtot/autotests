Feature: K_Project
I open taskform on Project

@Project
Scenario: I open taskform on Project
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I open taskform on Project
	Then I should see that taskform on Project is open