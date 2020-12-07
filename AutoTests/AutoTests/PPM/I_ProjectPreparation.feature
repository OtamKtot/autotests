Feature: I_ProjectPreparation
I complete ProjectPreparation

@ProjectPreparation
Scenario: I complete ProjectPreparation
	Given I navigate to application and login as Rukovoditel
	When I complete ProjectPreparation
	Then I should see that ProjectPreparation is complete