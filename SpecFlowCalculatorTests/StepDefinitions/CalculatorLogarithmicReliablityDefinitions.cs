using ICT3112_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorLogarithimicReliabilityDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public CalculatorLogarithimicReliabilityDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }



        [When(@"I have entered (.*) for initial intensity, (.*) for average failures, and (.*) for decay parameter into the calculator and press LCFI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLCFI(double num1, double num2, double num3)
        {
            _result = _calculator.LogarithmicCurrentFailureIntensity(num1, num2, num3);
        }

        [Then(@"the LCFI result should be (.*)")]
        public void ThenTheLCFIShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }

        [When(@"I have entered (.*) for initial intensity, (.*) for decay parameter, and (.*) for time into the calculator and press LANF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressLANF(double num1, double num2, double num3)
        {
            _result = _calculator.LogarithmicAverageNumberOfExpectedFailures(num1, num2, num3);
        }

        [Then(@"the LANF result should be (.*)")]
        public void ThenTheLANFResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }
    }
}
