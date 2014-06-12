using System;
using System.Runtime.Remoting.Messaging;
using System.Text;
using NUnit.Framework;

namespace TDD.Katas.FizzBuzz
{
    public class FizzBuzz
    {
        public static string FizzBuzzPrinter(int numberToCheck)
        {
            IsNumberOutOfRange(numberToCheck);
            var fizzBuzzResult = string.Empty;
            if (IsFizz(numberToCheck)) fizzBuzzResult += "Fizz";
            if (IsBuzz(numberToCheck)) fizzBuzzResult += "Buzz";
            if (IsNeitherFizzNorBuzz(fizzBuzzResult)) fizzBuzzResult += numberToCheck;
            return fizzBuzzResult;
        }

        public static string PrintNumbers()
        {
            var fizzBuzz = string.Empty;
            for (int i = 1; i <= 100; i++)
            {
                fizzBuzz += FizzBuzzPrinter(i) + " ";
            }
            return fizzBuzz.Trim();
        }

        private static bool IsNeitherFizzNorBuzz(string fizzBuzzResult)
        {
            return string.IsNullOrEmpty(fizzBuzzResult);
        }

        private static bool IsFizz(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }

        private static bool IsBuzz(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }

        private static void IsNumberOutOfRange(int numberToCheck)
        {
            if (numberToCheck <= 0 || numberToCheck > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
             
        }
    }
}