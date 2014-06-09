using System;
using System.Text;
using NUnit.Framework;

namespace TDD.Katas.FizzBuzz
{
    public class FizzBuzz
    {

        public static string FizzBuzzPrinter()
        {
            var fizzBuzzResult = PrintFizzBuzzNumbers();
            return fizzBuzzResult;
        }

        public static string FizzBuzzPrinter(int numberToCheck)
        {
            IsNumberOutOfBounds(numberToCheck);
            var fizzBuzzResult = GetAFizzBuzz(numberToCheck);
            if (string.IsNullOrEmpty(fizzBuzzResult))
            {
                fizzBuzzResult = GetABuzz(numberToCheck);
            }
            if (string.IsNullOrEmpty(fizzBuzzResult))
            {
                fizzBuzzResult = GetAFizz(numberToCheck);
            }
            return fizzBuzzResult;
        }

        private static string PrintFizzBuzzNumbers()
        {
            var fizzBuzzResult = string.Empty;
            for (int i = 1; i <= 100; i++)
            {
                var result = string.Empty;
                if (IsNumberFizz(i)) result += "Fizz";
                if (IsNumberBuzz(i)) result += "Buzz";
                if (IsNormalNumber(result)) result += i;
                fizzBuzzResult += " " + result;
            }
            return fizzBuzzResult.Trim();
        }

        private static bool IsNormalNumber(string currentResult)
        {
            return string.IsNullOrEmpty(currentResult);
        }

        private static void IsNumberOutOfBounds(int numberToCheck)
        {
            if (numberToCheck > 100 || numberToCheck < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private static string GetAFizzBuzz(int numberToCheck)
        {
            var result = string.Empty;
            if (IsNumberFizz(numberToCheck) && IsNumberBuzz(numberToCheck))
            {
                result += "FizzBuzz";
            }
            return result;
        }

        private static string GetAFizz(int numberToCheck)
        {
            var result = string.Empty;
            if (IsNumberFizz(numberToCheck))
            {
                result += "Fizz";
            }
            return result;
        }

        private static string GetABuzz(int numberToCheck)
        {
            var result = string.Empty;
            if (IsNumberBuzz(numberToCheck) && IsNumberBuzz(numberToCheck))
            {
                result += "Buzz";
            }
            return result;
        }

        private static bool IsNumberFizz(int numberToFizz)
        {
            return numberToFizz % 3 == 0;
        }

        private static bool IsNumberBuzz(int numberToBuzz)
        {
            return numberToBuzz % 5 == 0;
        }
    }
}