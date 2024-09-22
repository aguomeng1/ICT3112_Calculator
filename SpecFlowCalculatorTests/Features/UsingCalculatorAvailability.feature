Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this

@Availability
	Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered 100 and 10 into the calculator and press MTBF
	Then the MTBF result should be 110
@Availability
	Scenario: Calculating Availability
	Given I have a calculator
	When I have entered 100 and 110 into the calculator and press Availability
	Then the availability result should be 90.91%

@Availability
	Scenario: Zero MTTF and MTTR
	Given I have a calculator
	When I have entered 0 and 0 into the calculator and press MTBF
	Then the MTBF result should be 0

@Availability
	Scenario: Calculate MTTR
	Given I have a calculator
	When I have entered 210 for MTBF and 100 for MTTF into the calculator and press MTTR
	Then the MTTR result should be 110

@Availability
	Scenario: Calculate MTTF
	Given I have a calculator
	When I have entered 210 for MTBF and 100 for MTTR into the calculator and press MTTF
	Then the MTTF result should be 110
