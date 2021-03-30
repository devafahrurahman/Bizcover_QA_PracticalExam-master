Feature: Login
	In order to use the system
	As a registered user of the system
	I want to be able to log in to the system

Scenario: Log In
	Given I am in the home page of the system
	When I enter my username and password
	| UserName                | Password |
	| lorenad@bizcover.com.au | test1234 |
	Then I should be redirected to my Account Page
