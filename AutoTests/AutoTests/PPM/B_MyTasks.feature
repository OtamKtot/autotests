Feature: B_MyTasks
I can login at system and i can work in MyTasksList

@CreateTicket
Scenario: Create Ticket
	Given I navigate to application and login as Project
	When I Create Ticket
	Then I should see that Ticket is created