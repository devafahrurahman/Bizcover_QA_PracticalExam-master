Feature: Register
	In order to use the system
	As a new user
	I want to register an account on the system

Scenario: Check E-mail
	Given I am in the home page of the system
	When I enter my email
	| Email              |
	| coba3131@gmail.com |
	And My email is not registered 
	Then I should be redirected to account creation page

Scenario: Create an Account
	Given I am in the create an account page
	When I enter my personal infomation
	| FirstName   | LastName | Password     | 
	| QA          | Engineer | QaEngineer99 |
	And I enter my address
	| Company | Address  | Address2 | City    | PostalCode | AdditionalInformation | HomePhone | MobilePhone  | AssignAddress  |
	| coba	  | Cilinaya | Company  | Mataram | 83121      | Nothing               | 644942    | 081123125133 | CIlinaya Indah |
	And I click register button
	Then I should be redirected to my Account Page