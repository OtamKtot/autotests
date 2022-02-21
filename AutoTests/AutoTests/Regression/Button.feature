Feature: Button

		@mytag
Scenario Outline: Add Button At Record Template
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select BusinessApp
	Given I select Test BusinessApp
	Given I select Template
	Given I select Test Record Template
	Given I select Button Area
	When I Create Button
	Then I should see Button in Template