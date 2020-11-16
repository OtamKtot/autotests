Feature: L_CreateVersion
I create version

	@ConceptualDesignCreateVersion
Scenario: I create version of ConceptualDesign
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I create version of ConceptualDesign
	Then I should see that version of ConceptualDesign is create
	