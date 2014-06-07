using System;
using System.Text;

namespace TDD.Katas.FizzBuzz
{
    public class FizzBuzz
    {
        
        public static string PrintNumbers()
        {
            var fizzBuzzResult = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                fizzBuzzResult.Append(FizzBuzzChecker(i));
            }
            return fizzBuzzResult.ToString().Trim();
        }

        public static bool NumberChecker(int numberToCheck)
        {
         
            return numberToCheck > 0 && numberToCheck <= 100;
        }

        public static string FizzBuzzChecker(int numberToCheck)
        {
            if (!NumberChecker(numberToCheck))
            {
                return String.Empty;
            }
            if (numberToCheck % 15 == 0)
            {
                return " FizzBuzz";
            }
            if (numberToCheck % 3 == 0)
            {
                return " Fizz";
            }
            return numberToCheck % 5 == 0 ? " Buzz" : string.Concat(" ",numberToCheck.ToString());
        }
    }
}