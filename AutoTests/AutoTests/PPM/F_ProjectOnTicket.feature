Feature: F_ProjectOnTicket
I complete ProjectOnTicket

@TechnicalRequirements
Scenario: I complete ProjectOnTicket
Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| Project    | 1   |
	And I click login
	And I complete ProjectOnTicket
	Then I should see that ProjectOnTicket is complete