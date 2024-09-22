using ICT3112_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorDivisionDefinitions
    {
        //private readonly CalculatorData _calculatorData;
        private Calculator _calculator; 
        private double _result;

        public CalculatorDivisionDefinitions(Calculator calculator) //CalculatorData calculatorData  
        {
            _calculator = calculator;
            //_calculatorData = calculatorData;
        }



        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double num1, double num2)
        {
            //_result = _calculatorData.Calculator.Divide(num1, num2);
            _result = _calculator.Divide(num1, num2);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected).Within(0.0001));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
