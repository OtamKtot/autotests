Feature: B_AttributeFeature
	Add Attribute

	@mytag
Scenario Outline: Add Record
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	And I select Template
	Then I should see <TestName> RecordTemplate in list Templates
	When I navigate into <TestName> RecordTemplate
	And I navigate into Attribute
	And I create attribute
			| Name             | Alias           |
		| <TestName>       | <TestAlias>     |
	Then I should see <TestName> attribute in list attributes
	Examples: 
    | TestName       | TestAlias |
    | Name1          | Alias1    |
    | TestName1      | TestAlias1    |