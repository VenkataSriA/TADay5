Feature: TMFeature

[A short summary of the feature]
As a TurnUp Portal user
I would like to Create, Edit, and Delete Time and Materials records
So that I can manage Time and Material records of employees.

@tag1
Scenario: [scenario name]Create a Time and Materials record with valid details.
	Given [context]I am logged into TurnUp portal successfully.
	When [action]I Navigate to Time and Material page
	And I Create a Time and Material record
	Then [outcome]The Record should be created successfully.
