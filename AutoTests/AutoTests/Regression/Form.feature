Feature: Form
	Add Attribute in Form
	#@ignore
	@mytag
Scenario Outline: Add Attribute in Form
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select BusinessApp
	Given I select system BusinessApp
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

	@ignore
		@FirstAttribute
	Scenario Outline: Add First Attribute in Form
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select BusinessApp
	Given I select system BusinessApp
	Given I select Template
	Given I navigate into <TestName> RecordTemplate
	Given I navigate into Form
	When I drag and drop Attribute into Form
	#When I drag and drop <TestName> Attribute <TestAlias> into Form
	Then I should see <TestName> attribute in Form
		Examples: 
    | TestName       | TestAlias |
    | Name1          | Alias1    |
    | TestName1      | TestAlias1    |

		@ignore
		@mytag
Scenario Outline: Add All Type Attributes in Form
	Given I navigate to application and login as Admin
	Given I navigate to global configuration
	Given I select BusinessApp
	Given I select system BusinessApp
	Given I select Template
	Given I navigate into <TestName> RecordTemplate
	Given I navigate into Form
	Given I create all type attributes
	#When I drag and drop Attribute into Form
	When I drag and drop Attributes into Form
	Then I should see attributes in Form
		Examples: 
    | TestName       | TestAlias |
    | Name1          | Alias1    |