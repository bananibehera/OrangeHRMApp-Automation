Feature: ManageAdminUser
	As Orange HRMs administration, 
	I would like to manage user profiles within the portal

@mytag
Scenario: Add a new admin user
	Given I login to Orange HRM portal as an administration
	And I navigate to systems user page
	Then I should able to create a new user successfully

Scenario: Edit an existing admin user
	Given I login to Orange HRM portal as an administration
	And I navigate to systems user page
	Then I should able to edit an existing user successfully

Scenario: Delete an existing admin user profile
    Given I login to Orange HRM portal as an administration
	And I navigate to systems user page
	Then I should able to delete an existing user successfully


