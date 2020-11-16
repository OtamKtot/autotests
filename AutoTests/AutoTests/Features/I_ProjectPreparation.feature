Feature: I_ProjectPreparation
I complete ProjectPreparation

@ProjectPreparation
Scenario: I complete ProjectPreparation
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Rukovoditel    | 1   |
	And I click login
	And I complete ProjectPreparation
	Then I should see that ProjectPreparation is complete