Feature: L_CreateVersion
I create version

	@ConceptualDesignCreateVersion
Scenario: I create version of ConceptualDesign
	Given I navigate to application and login as Rukovoditel
	When I create version of ConceptualDesign
	Then I should see that version of ConceptualDesign is create
	