Feature: manager

A short summary of the feature

@Manager
Scenario: verify manager login 
	Given manager login
	When  when manager clicks on manager login button
	Then click on add customer
    And fill the fields name, lname and code
	| name  | lname | code  |
	| ankii | amin  | 34567 |
	Then click on add customers

	