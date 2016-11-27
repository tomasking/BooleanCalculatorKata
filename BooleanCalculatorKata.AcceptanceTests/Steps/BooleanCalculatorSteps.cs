using System;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BooleanCalculatorKata.AcceptanceTests.Steps
{
    [Binding]
    public class BooleanCalculatorSteps
    {
        private const string InputValueKey = "InputValue";
        private const string ResultKey = "ResultKey";

        [Given(@"The input value (.*)")]
        public void GivenTheInputValue(string inputValue)
        {
            ScenarioContext.Current.Add(InputValueKey, inputValue);
        }

        [When(@"I request the result")]
        public void WhenIRequestTheResult()
        {
            var booleanCalculator = new BooleanCalculator();
            var inputValue = ScenarioContext.Current[InputValueKey].ToString();
            bool result = booleanCalculator.Calculate(inputValue);
            ScenarioContext.Current.Add(ResultKey, result);
        }

        [Then(@"I should get the following (.*)")]
        public void ThenIShouldGetTheFollowing(string expectedValue)
        {
            bool result = bool.Parse(ScenarioContext.Current[ResultKey].ToString());
            result.Should().Be(ParseAsBool(expectedValue));
        }

        private bool ParseAsBool(string input)
        {
            if (input == "T") return true;
            if (input == "F") return false;
            throw new Exception("Unrecognised input ${input}");
        }
    }
}