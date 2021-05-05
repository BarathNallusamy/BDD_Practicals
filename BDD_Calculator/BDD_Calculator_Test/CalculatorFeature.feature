Feature: CalculatorFeature
	Simple calculator for adding two numbers
	in order to avoid silly mistakes
	As a math idiot
	I want to be able to do simple calculations

@mytag
Scenario: Add two numbers
	Given I have a calculator
	And I enter 5 and 2 into the calculator
	When I press add
	Then the result should be 7

@mytag
Scenario: Subtract two numbers
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press subtract
	Then the result should be <result>

Examples:
| input1 | input2 | result | 
| 1      | 1      | 0      | 
| 0      | 1      | -1     | 
| 100    | -1     | 101    |

@mytag
Scenario: Multiply
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press multiply
	Then the result should be <result>
Examples:
| input1 | input2 | result | 
| 1      | 1      | 1      | 
| 2      | 3	  | 6      | 
| 9      | 9      | 81     |
| 5      | -17    | -85    |


@mytag
Scenario: Divide
	Given I have a calculator
	And I enter <input1> and <input2> into the calculator
	When I press divide
	Then the result should be <result>
Examples:
| input1 | input2 | result | 
| 1      | 1      | 1      | 
| 8      | 2	  | 4      | 
| 100    | 4      | 25     |


@mytag
Scenario: Divide by Zero
	Given I have a calculator
	And I enter <input1> and 0 into the calculator
	Then a DivideByZero Exception should be thrown with the exception message "Cannot Divide By Zero" when I press Divide
Examples:
| input1 | 
| 1      | 
| 6      | 
