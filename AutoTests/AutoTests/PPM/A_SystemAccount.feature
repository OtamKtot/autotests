Feature: A_SystemAccount
	Open SystemAccountTemplate

@mytag
Scenario: 	Open SystemAccountTemplate
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	When I open SystemAccountTemplate
	Then I should see that SystemAccountTemplate is opened