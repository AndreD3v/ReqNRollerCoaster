using Serilog;

namespace ReqNRollerCoasterProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _result;

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            _firstNumber = firstNumber;
            Log.Information($"_firstNumber = {_firstNumber}");
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            _secondNumber = secondNumber;
            Log.Information($"_secondNumber = {_secondNumber}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _firstNumber + _secondNumber;
            Log.Information($"_result = {_result}");
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            _result.Should().Be(expectedResult);
        }
    }
}
