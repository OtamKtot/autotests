Feature: J_ConceptualDesign
I complete ConceptualDesign

@ConceptualDesignEdit
Scenario: I edit ConceptualDesign
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I edit ConceptualDesign
	Then I should see that ConceptualDesign is edit
