namespace BooleanCalculatorKata
{
    public class BooleanCalculator
    {
        public bool Calculate(string inputValue)
        {
            if (inputValue == "¬T")
            {
                return false;
            }

            if (inputValue == "¬F")
            {
                return true;
            }

            return false;
        }
    }
}