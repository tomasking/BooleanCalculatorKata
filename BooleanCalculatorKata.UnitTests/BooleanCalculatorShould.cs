using FluentAssertions;
using NUnit.Framework;

namespace BooleanCalculatorKata.UnitTests
{
    [TestFixture]
    public class BooleanCalculatorShould
    {
        private BooleanCalculator booleanCalculator;

        [SetUp]
        public void Setup()
        {
            booleanCalculator = new BooleanCalculator();
        }

        [TestCase("NOT TRUE", false)]
        [TestCase("NOT FALSE", true)]
        public void GiveTheNotOfAValue_GivenAnInputValue(string inputValue, bool expectedValue)
        {
            var result = booleanCalculator.Calculate(inputValue);

            result.Should().Be(expectedValue);
        }

        [TestCase("TRUE AND TRUE", true)]
        [TestCase("TRUE AND FALSE", false)]
        [TestCase("FALSE AND TRUE", false)]
        [TestCase("FALSE AND FALSE", false)]
        public void GiveTheAndOfAValue_GivenAnInputValue(string inputValue, bool expectedValue)
        {
            var result = booleanCalculator.Calculate(inputValue);

            result.Should().Be(expectedValue);
        }

        [TestCase("TRUE OR TRUE", true)]
        [TestCase("TRUE OR FALSE", true)]
        [TestCase("FALSE OR TRUE", true)]
        [TestCase("FALSE OR FALSE", false)]
        public void GiveTheOrOfAValue_GivenAnInputValue(string inputValue, bool expectedValue)
        {
            var result = booleanCalculator.Calculate(inputValue);

            result.Should().Be(expectedValue);
        }
    }
}