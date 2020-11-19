Feature: A_Template
	Add Record Template

@mytag
Scenario: Add Record Template
	Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| admin    | admin123  |
	And I click login
	Then I should see user logged in to the application
	When I navigate to global configuration
	And I select Template
	And I add RecordTemplate
		| Name             | Alias           |
		| <TestName>       | <TestAlias>     |
	And I navigate to global configuration
	And I select Template
	Then I should see <TestName> RecordTemplate in list Templates
		Examples: 
    | TestName       | TestAlias |
    | Name1          | Alias1    |
    | TestName1      | TestAlias1    |