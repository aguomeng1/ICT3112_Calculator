using ICT3112_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorDefectDensityDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public CalculatorDefectDensityDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }



        [When(@"I have entered (.*) for numbers of defects and (.*) for lines of code into the calculator and press DD")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDD(double num1, double num2)
        {
            _result = _calculator.DefectDensity(num1, num2);
        }

        [Then(@"the DD result should be (.*)")]
        public void ThenTheDDShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }

        [When(@"I have entered (.*) for KCSI, (.*) for KSSI, (.*) for changed/duplicate code, and (.*) for deleted code into the calculator and press SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSSI(double num1, double num2, double num3, double num4)
        {
            _result = _calculator.CustomSSI(num1, num2, num3, num4);
        }

        [Then(@"the SSI result should be (.*)")]
        public void ThenSSIResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }
    }
}
