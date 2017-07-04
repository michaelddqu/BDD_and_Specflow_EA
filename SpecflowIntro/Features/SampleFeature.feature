Feature: SampleFeature

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with mandatary details
    #Given I have opened my application
	#When I should see employee datails page
	Then I fill all the mandatory details in form
	| Name     | Age | Phone      | Email                          |
	| Karithik | 28  | 9098023842 | karthik@executeautiomation.com |
	| John     | 29  | 9098023843 | john@executeautiomation.com    |
	| Cathy    | 30  | 9098023844 | cathy@executeautiomation.com   |
	#And I click the save button
	#Then I should see all the details saved in my application and DB

	Scenario Outline: Create a new employee with mandatary details for different iterations
    #Given I have opened my application
	#When I should see employee datails page
	Then I fill all the mandatory details in form <Name>, <Age>, <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples: 
	| Name     | Age | Phone      |
	| Karithik | 28  | 9098023842 |
	| John     | 29  | 9098023843 |
	| Cathy    | 30  | 9098023844 |

Scenario: Check if I could get the details entered via Table from Extended Steps
	When I fill all th mandatory detals in form
	| Name      | Age | Phone       | Email            |
	| ShareName | 30  | 01234567890 | sharename@qq.com |
	| AdminName | 40  | 01234567891 | adminname@qq.com |
    Then I should get the same value from Extened steps