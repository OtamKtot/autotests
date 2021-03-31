Feature: A_Template
	Add Record Template

@mytag
Scenario: Add Record Template
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select Template
	Given I add RecordTemplate
		| Name             | Alias           |
		| <TestName>       | <TestAlias>     |
	Given I navigate to global configuration
	When I select Template
	Then I should see <TestName> RecordTemplate in list Templates
		Examples: 
    | TestName       | TestAlias |
    | Name1          | Alias1    |
    | TestName1      | TestAlias1    |