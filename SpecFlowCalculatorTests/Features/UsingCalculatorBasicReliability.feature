Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

#Assume that all results are 2 dp

@BasicReliability
Scenario: Calculate Initial Failure Intensity using Musa Basic Model
	Given I have a calculator	
	When I have entered <init> for initial intensity, <avg> for average failures, and <total> for total failures into the calculator and press CFI
	Then the CFI result should be <result>
	Examples: 
	| init    | avg | total | result |
	| 10      | 50  | 100   | 5.00   |


@BasicReliability
Scenario: Calculate Average Number of Expected Failures using Musa Basic Model
	Given I have a calculator
	When I have entered <init> for initial intensity, <total> for total failures, and <t> for current time into the calculator and press ANF
	Then the ANF result should be <result>
	Examples: 
	| init    | total | t	   | result |
	| 10      | 100   | 100    | 100.00 |

