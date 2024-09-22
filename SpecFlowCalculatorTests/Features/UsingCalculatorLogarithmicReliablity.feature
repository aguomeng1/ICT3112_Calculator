Feature: UsingCalculatorLogarithmicReliability
In order to calculate the Logarithmic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@LogarithmicReliability
Scenario: Calculate Current Failure Intensity using Musa Logarithmic Model 
	Given I have a calculator	
	When I have entered <init> for initial intensity, <avg> for average failures, and <decay> for decay parameter into the calculator and press LCFI
	Then the LCFI result should be <result>
	Examples: 
	| init    | avg | decay | result |
	| 10      | 50  | 0.02  | 3.68   |


@LogarithmicReliability
Scenario: Calculate Average Number of Expected Failures using Musa Logarithmic Model
	Given I have a calculator
	When I have entered <init> for initial intensity, <decay> for decay parameter, and <t> for time into the calculator and press LANF
	Then the LANF result should be <result>
	Examples: 
	| init    | decay | t      |  result |
	| 10      | 0.02  | 10     |  54.93  | 
	| 10      | 0.02  | 100    |  152.23 | 

