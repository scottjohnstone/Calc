Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Calc/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag

Scenario Outline: Add Two Numbers
	Given I navigated to Standard Calculator
	And I have entered <SummandOne> into calculator
	And I press plus
	And I have entered <SummandTwo> into calculator
	When I press equal
	Then the result should be <Result> on the screen

Scenarios: 
		| SummandOne | SummandTwo | Result |       
		| 50         | 70         | 120    | 
		| 1          | 10         | 11     |

Scenario: Calculate two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120