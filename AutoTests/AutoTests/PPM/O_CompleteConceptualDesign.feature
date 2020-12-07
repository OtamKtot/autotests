Feature: O_CompleteConceptualDesign
I complete ConceptualDesign

	@ConceptualDesignComplete
Scenario: I complete ConceptualDesign
	Given I navigate to application and login as Rukovoditel
	When I complete ConceptualDesign
	Then I should see that ConceptualDesign is complete