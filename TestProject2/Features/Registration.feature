Feature: Registration
	In other to benefit from the website
	I would need to register

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I enter my First name
	And I enter my Last Name
	And I enter my email address
	And I enter my contact number
	#And I click on the gender
	#And I click on Hobbies
	And I enter Password
	And i re-enter my confirmed Password
	#When I click on the submit button
	#Then I should register successfully