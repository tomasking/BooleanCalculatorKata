using FluentAssertions;
using NUnit.Framework;

namespace BooleanCalculatorKata.UnitTests
{
    [TestFixture]
    public class BooleanCalculatorShould
    {
        [TestCase("¬T", false)]
        [TestCase("¬F", true)]
        public void GiveTheNotOfAValue_GivenTheValue(string inputValue, bool expectedValue)
        {
            BooleanCalculator booleanCalculator = new BooleanCalculator();

            var result = booleanCalculator.Calculate(inputValue);

            result.Should().Be(expectedValue);
        }
    }
}
