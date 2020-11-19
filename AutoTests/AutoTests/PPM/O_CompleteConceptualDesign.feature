Feature: O_CompleteConceptualDesign
I complete ConceptualDesign

	@ConceptualDesignComplete
Scenario: I complete ConceptualDesign
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I complete ConceptualDesign
	Then I should see that ConceptualDesign is complete