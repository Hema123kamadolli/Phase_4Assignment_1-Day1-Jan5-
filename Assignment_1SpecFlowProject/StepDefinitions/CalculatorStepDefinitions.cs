using CalculatorLib;

namespace Assignment_1SpecFlowProject.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator;
        private int result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Calculator();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.Fnum = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            calculator.Snum = number;
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calculator.Mul();
        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            result = calculator.Sub();
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calculator.Div();
        }
        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {

            result.Should().Be(result);
        }
    }
}
