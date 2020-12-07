Feature: J_ConceptualDesign
I complete ConceptualDesign

@ConceptualDesignEdit
Scenario: I edit ConceptualDesign
	Given I navigate to application and login as Rukovoditel
	When I edit ConceptualDesign
	Then I should see that ConceptualDesign is edit
