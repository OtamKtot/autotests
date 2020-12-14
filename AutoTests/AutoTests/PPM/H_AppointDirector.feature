Feature: H_AppointDirector
I complete AppointDirector

@AppointDirector
Scenario: I complete AppointDirector
	Given I navigate to application and login as Director
	When I open task and add Rukovoditel in collection
	When I complete AppointDirector
	Then I should see that AppointDirector is complete