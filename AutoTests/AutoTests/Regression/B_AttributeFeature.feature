Feature: B_AttributeFeature
	Add Attribute

	@mytag
Scenario Outline: Add Record
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select BusinessApp
	Given I select system BusinessApp
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
    | TestName1      | TestAlias1|

		@mytag
Scenario Outline: Add Text Attribute
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select BusinessApp
	Given I select Test BusinessApp
	Given I select Template
	Given I select Test Record Template
	Given I navigate into Attribute
	When I create attribute Image type
	When I create attribute Document type
	#When I create attribute User type
	When I create attribute Duration type
	When I create attribute Logic type
	When I create attribute Text type
	When I create attribute Number type
	When I create attribute Date and time type
	Then I should see Text attribute in list attributes
