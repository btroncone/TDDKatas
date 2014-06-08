using System;
using System.Text;

namespace TDD.Katas.FizzBuzz
{
    public class FizzBuzz
    {
        
        public static string NumberPrinter()
        {
            var fizzBuzzString = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                if (IsFizz(i)) fizzBuzzString.Append("Fizz");
                if (IsBuzz(i)) fizzBuzzString.Append("Buzz");
                if (!IsBuzz(i) && !IsFizz(i)) fizzBuzzString.Append(i);
                fizzBuzzString.Append(" ");
            }
            return fizzBuzzString.ToString().Trim();
        }
        public static bool IsFizz(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }
        public static bool IsBuzz(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }
    }
}