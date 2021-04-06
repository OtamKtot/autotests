Feature: B_AttributeFeature
	Add Attribute

	@mytag
Scenario Outline: Add Record
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select Template
	Given I navigate into <TestName> RecordTemplate
	Given I navigate into Attribute
	When I create attribute
         | Name | Alias |
         |   <TestName>   |  <TestAlias>    |
	Then I should see <TestName> attribute in list attributes
	Examples: 
    | TestName       | TestAlias |
    | Name1          | Alias1    |
    | TestName1      | TestAlias1    |