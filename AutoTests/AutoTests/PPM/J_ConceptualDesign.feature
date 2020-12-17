Feature: J_ConceptualDesign
I complete ConceptualDesign

@ConceptualDesignEdit
Scenario: I edit ConceptualDesign
	Given I navigate to application and login as Rukovoditel
	Given I open task and add edit four record in collection
	Given I add three childs for three variants
	When I planned Work in ConceptualDesign
	Then I should see that ConceptualDesign is edit
