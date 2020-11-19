Feature: B_AttributeFeature
	Add Attribute

	@mytag
Scenario Outline: Add Record
	Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| admin    | admin123   |
	And I click login
	Then I should see user logged in to the application
	When I navigate to global configuration
	And I select Template
	Then I should see <TestName> RecordTemplate in list Templates
	When I navigate into <TestName> RecordTemplate
	And I navigate into Attribute
	And I create attribute
	Examples: 
	| TestName     |
	| Name1 |
	| TestName1 |