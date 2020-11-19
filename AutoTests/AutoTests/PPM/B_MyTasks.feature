Feature: B_MyTasks
I can login at system and i can work in MyTasksList

@CreateTicket
Scenario: Create Ticket
	Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I Create Ticket
	Then I should see that Ticket is create