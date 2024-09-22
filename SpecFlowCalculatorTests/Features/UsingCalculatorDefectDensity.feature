#Qn 19: Enhance/Customize command line calculator to include software quality metric calculations
#Qn 20: Feature: Adding Defect Density Calculation, User Story: As a software quality metric enthusiast, I want to use my calculator to calculate defect density, so that I can quickly assess the number of defects in the software relative to its size.
#Qn 20: Feature: Adding Defect Density Calculation, User Story, As a software quality metric enthusiast, I want to use my calculator to calculate the new total SSI for successive releases, so that I can keep track of system changes to calculate the new defect density.
#Qn 20: Feature: Adding Musa Logarithmic Model Calculation, User Story: As software quality metric enthusiast, I want to use my calculato to calculate the failure intensity and the number of expected failures using the Musa Logarithmic model, so that I can predict software reliability accurately.
#Qn 21: Features: Adding Defect Density Calculation, Adding Musa Logarithmic Model Calculation
#Qn 23: Issues faced: Matching step definitions because I named Basic Musa Model a generic name e.g. Calculate Initial Failure Intensity, so i had to refactor some codes and  function from that as well as calculator to make sure it is unique.
Feature: UsingCalculatorDefectDensity

@DefectDensity
Scenario: Calculate Defect Density
	Given I have a calculator	
	When I have entered <nd> for numbers of defects and <size> for lines of code into the calculator and press DD
	Then the DD result should be <result>
	Examples: 
	| nd   | size | result |
	| 200  | 100  |  2.00  |
	| 100  | 50   |  2.00  |
	| 10   | 20   |  0.50  |

@DefectDensity
Scenario: Calculate New Total SSI
	Given I have a calculator
	When I have entered <kcsi> for KCSI, <kssi> for KSSI, <cc> for changed/duplicate code, and <deleted> for deleted code into the calculator and press SSI
	Then the SSI result should be <result>
	Examples: 
	| kcsi    | kssi  | cc	   | deleted | result |
	| 60      | 10    | 3      |    1    |  66    |

