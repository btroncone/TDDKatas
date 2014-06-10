using System;
using System.Runtime.Remoting.Messaging;
using System.Text;
using NUnit.Framework;

namespace TDD.Katas.FizzBuzz
{
    public class FizzBuzz
    {
        public static string GetFizzBuzz()
        {
            var result = PrintFizzBuzzNumbers();
            return result;
        }       
        public static string GetFizzBuzz(int numberToCheck)
        {
            IsNumberWithinRange(numberToCheck);
            var fizzBuzzResult = string.Empty;
            if (IsNumberFizz(numberToCheck)) fizzBuzzResult += "Fizz";
            if (IsNumberBuzz(numberToCheck)) fizzBuzzResult += "Buzz";
            if (string.IsNullOrEmpty(fizzBuzzResult)) fizzBuzzResult += numberToCheck;
            return fizzBuzzResult;
        }
        private static string PrintFizzBuzzNumbers()
        {
            var result = string.Empty;
            for (int i = 1; i <= 100; i++)
            {
                result += GetFizzBuzz(i) + " ";
            }
            return result.Trim();
        }
        private static bool IsNumberFizz(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }
        private static bool IsNumberBuzz(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }

        private static void IsNumberWithinRange(int numberToCheck)
        {
            if (numberToCheck < 1 || numberToCheck > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}