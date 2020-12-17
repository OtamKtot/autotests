Feature: I_ProjectPreparation
I complete ProjectPreparation

@ProjectPreparation
Scenario: I complete ProjectPreparation
	Given I navigate to application and login as Rukovoditel
	Given I open task and add Ispolnitel in collection and create phase
	Given I add document in collection
	When I complete ProjectPreparation
	Then I should see that ProjectPreparation is complete