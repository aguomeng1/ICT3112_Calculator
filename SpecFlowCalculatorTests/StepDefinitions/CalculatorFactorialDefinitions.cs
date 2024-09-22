using ICT3112_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class FactorialCalculationStepDefinitions
    {
        private Calculator _calculator;
        private long _result;

        public FactorialCalculationStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }

        [When(@"I calculate the factorial of (.*)")]
        public void WhenICalculateTheFactorialOf(int number)
        {
            _result = _calculator.Factorial(number);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }
    }
}