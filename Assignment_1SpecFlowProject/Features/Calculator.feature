Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Assignment_1SpecFlowProject/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Mul two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are multiplied
	Then the result should be 50

	Scenario: Sub two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are substracted
	Then the result should be 5

	Scenario: Div two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are divided
	Then the result should be 2

