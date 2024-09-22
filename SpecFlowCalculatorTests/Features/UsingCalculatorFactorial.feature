Feature: UsingCalculatorFactorial

@Factorial
Scenario: Calculate factorial of zero
    Given I have a calculator
    When I calculate the factorial of 0
    Then the factorial result should be 1

@Factorial
Scenario: Calculate normal factorial
    Given I have a calculator
    When I calculate the factorial of <value1>
    Then the factorial result should be <value2>

    Examples:
    | value1 | value2 |
    | 1     | 1        |
    | 3     | 6        |
    | 4     | 24       |
    | 6     | 720      |
    | 10    | 3628800  |