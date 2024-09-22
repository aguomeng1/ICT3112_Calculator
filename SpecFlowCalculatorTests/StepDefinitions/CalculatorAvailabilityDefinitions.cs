using ICT3112_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorAvailabilityDefinitions
    {
        //private readonly CalculatorData _calculatorData;
        private Calculator _calculator;
        private double _result;

        public CalculatorAvailabilityDefinitions(Calculator calculator) //CalculatorData calculatorData  
        {
            _calculator = calculator;
            //_calculatorData = calculatorData;
        }



        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double num1, double num2)
        {
            //_result = _calculatorData.Add.(num1, num2);
            _result = _calculator.MTBF(num1, num2);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheMTBFShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double num1, double num2)
        {
            //_result = _calculatorData.Calculator.Divide(num1, num2);
            _result = _calculator.Availability(num1, num2);
        }

        [Then(@"the availability result should be (.*)%")]
        public void ThenTheAvailabilityResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }

        [When(@"I have entered (.*) for MTBF and (.*) for MTTF into the calculator and press MTTR")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTTR(double num1, double num2)
        {
            //_result = _calculatorData.Subtract(num1, num2);
            _result = _calculator.MTTR(num1, num2);

        }

        [Then(@"the MTTR result should be (.*)")]
        public void ThenTheMTTRResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }

        [When(@"I have entered (.*) for MTBF and (.*) for MTTR into the calculator and press MTTF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTTF(double num1, double num2)
        {
            //_result = _calculatorData.Subtract(num1, num2);
            _result = _calculator.MTTR(num1, num2);

        }

        [Then(@"the MTTF result should be (.*)")]
        public void ThenTheMTTFResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.01));
        }
    }
}
