using System;
using System.Collections.Generic;

namespace BooleanCalculatorKata
{
    public class BooleanCalculator
    {
        public bool Calculate(string inputValue)
        {
            var operations = inputValue.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var result = Parse(operations);

            return result;
        }

        private bool Parse(string[] operations)
        {
            operations = ParseNotOperations(operations);
            operations = ParseAndOperations(operations);
            operations = ParseOrOperations(operations);

            if (operations[0] == "TRUE") return true;
            return false;
        }

        private string[] ParseNotOperations(string[] operations)
        {
            var reducedOperations = new List<string>();
            for (int index = 0; index < operations.Length; index++)
            {
                if (operations[index] == "NOT")
                {
                    if (operations[index + 1] == "TRUE")
                    {
                        reducedOperations.Add("FALSE");
                    }
                    else
                    {
                        reducedOperations.Add("TRUE");
                    }
                    index++;
                }
                else
                {
                    reducedOperations.Add(operations[index]);
                }
            }
            return reducedOperations.ToArray();
        }

        private string[] ParseAndOperations(string[] operations)
        {
            var reducedOperations = new Stack<string>();
            for (int index = 0; index < operations.Length; index++)
            {
                if (operations[index] == "AND")
                {
                    reducedOperations.Pop();
                    reducedOperations.Push(And(operations[index-1], operations[index+1]));
                    index = index + 2;
                }
                else
                {
                    reducedOperations.Push(operations[index]);
                }
            }
            return reducedOperations.ToArray();
        }

        private string[] ParseOrOperations(string[] operations)
        {
            var reducedOperations = new Stack<string>();
            for (int index = 0; index < operations.Length; index++)
            {
                if (operations[index] == "OR")
                {
                    reducedOperations.Pop();
                    reducedOperations.Push(Or(operations[index - 1], operations[index + 1]));
                    index = index + 2;
                }
                else
                {
                    reducedOperations.Push(operations[index]);
                }
            }
            return reducedOperations.ToArray();
        }

        private string And(string firstValue, string secondValue)
        {
            bool first = bool.Parse(firstValue);
            bool second = bool.Parse(secondValue);
            bool result = first & second;
            if (result) return "TRUE";
            return "FALSE";
        }

        private string Or(string firstValue, string secondValue)
        {
            bool first = bool.Parse(firstValue);
            bool second = bool.Parse(secondValue);
            bool result = first | second;
            if (result) return "TRUE";
            return "FALSE";
        }
    }
}