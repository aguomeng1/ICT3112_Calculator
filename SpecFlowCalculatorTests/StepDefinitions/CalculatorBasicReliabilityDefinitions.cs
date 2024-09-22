using ICT3112_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorBasicReliabilityDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public CalculatorBasicReliabilityDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }



        [When(@"I have entered (.*) for initial intensity, (.*) for average failures, and (.*) for total failures into the calculator and press CFI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCFI(double num1, double num2, double num3)
        {
            _result = _calculator.BasicCurrentFailureIntensity(num1, num2, num3);
        }

        [Then(@"the CFI result should be (.*)")]
        public void ThenTheCFIShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }

        [When(@"I have entered (.*) for initial intensity, (.*) for total failures, and (.*) for current time into the calculator and press ANF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressANF(double num1, double num2, double num3)
        {
            _result = _calculator.BasicAverageNumberOfExpectedFailures(num1, num2, num3);
        }

        [Then(@"the ANF result should be (.*)")]
        public void ThenTheANFResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }
    }
}
