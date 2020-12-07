Feature: K_Project
I open taskform on Project

@Project
Scenario: I open taskform on Project
	Given I navigate to application and login as Rukovoditel
	When I open taskform on Project
	Then I should see that taskform on Project is open