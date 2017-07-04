Feature: Reusability
	Reuse the information in other step definition/feature.
	Testing the multiline step reusability

@reuse
Scenario: Enter user details in UserForm
	Given I login to application
	| UserName | Password |
	| admin    | admin    |
	And I enter following details
    | Title | Initial | FirstName |
    | Mr.   | K       | Karthik   |

Scenario: Enter user details in UserFrom in 2 lines
    Given I login and enter user details
	Then I click save button