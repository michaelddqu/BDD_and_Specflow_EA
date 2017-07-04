Feature: SpecFlowExcel

@SpecFlowExcel
Scenario Outline: Add two digits
	Given I have input <a> into the calculator
	And I have input <b> into the calculator
	When I press add button
	Then I will get <c>

	@source:data.xlsx
	Examples: 
	| a | b | c |