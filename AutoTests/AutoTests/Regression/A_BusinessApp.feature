Feature: A_BusinessApp
	BusinessApp feature

@mytag
Scenario: Add BusinessApp
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select BusinessApp
	When I add BusinessApp
	Then I should see BusinessApp is created