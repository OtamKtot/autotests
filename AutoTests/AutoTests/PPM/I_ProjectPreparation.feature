Feature: I_ProjectPreparation
I complete ProjectPreparation

@ProjectPreparation
Scenario: I complete ProjectPreparation
	Given I navigate to application and login as Rukovoditel
	When I open task and add Ispolnitel in collection and create phase
	And I add document in collection
	And I complete ProjectPreparation
	Then I should see that ProjectPreparation is complete