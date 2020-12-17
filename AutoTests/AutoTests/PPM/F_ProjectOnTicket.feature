Feature: F_ProjectOnTicket
I complete ProjectOnTicket

@TechnicalRequirements
Scenario: I complete ProjectOnTicket
	Given I navigate to application and login as Project
	Given I open task and add record in collection
	When I complete ProjectOnTicket
	Then I should see that ProjectOnTicket is complete