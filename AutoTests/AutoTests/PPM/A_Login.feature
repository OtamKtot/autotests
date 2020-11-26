Feature: A_Login
I can Login in system

@LoginAdmin
Scenario: I login as Admin
	Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| admin    | admin123   |
	And I click login
	And I click logout
	Then I should see user logged in to the application
@LoginRukovoditel
Scenario: I login as Rukovoditel
	Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	Then I should see user logged in to the application
@LoginProject
Scenario: I login as Project
	Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	Then I should see user logged in to the application
@LoginDirector
Scenario: I login as Director
	Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Director    | 1   |
	And I click login
	Then I should see user logged in to the application