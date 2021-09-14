Feature: SomethingInteresting

@mytag
Scenario: Doing something causes something else
	Given I am authenticated to application as 'admin'
	When I open settings using menu
	Then Settings are opened
	And 'admin' settings are available