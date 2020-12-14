Feature: J_ConceptualDesign
I complete ConceptualDesign

@ConceptualDesignEdit
Scenario: I edit ConceptualDesign
	Given I navigate to application and login as Rukovoditel
	When I open task and add edit four record in collection
	And I add three childs for three variants
	And I planned Work in ConceptualDesign
	Then I should see that ConceptualDesign is edit
