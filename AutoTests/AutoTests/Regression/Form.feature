﻿Feature: Form
	Add Attribute in Form

	@mytag
Scenario Outline: Add Attribute in Form
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select Template
	Given I navigate into <TestName> RecordTemplate
	Given I navigate into Form
	#When I drag and drop Attribute into Form
	When I drag and drop <TestName> Attribute <TestAlias> into Form
	Then I should see <TestName> attribute in Form
		Examples: 
    | TestName       | TestAlias |
    | Name1          | Alias1    |
    | TestName1      | TestAlias1    |