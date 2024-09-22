using ICT3112_Calculator;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        //private readonly CalculatorData _calculatorData;
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorStepDefinitions(Calculator calculator) //CalculatorData calculatorData 
        {
            //_calculatorData = calculatorData;
            _calculator = calculator; 
        }

        /* DI to resolve and inject Calculator object automatically 
         * when it runs into a scenario where it needs to use this step definition
         * No need to instantiate as SpecFlow resolves it automatically, also manages its lifecycle */
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            //_calculatorData.Calculator = new Calculator();
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            //_result = _calculatorData.Calculator.Add(p0, p1);
            _result = _calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}