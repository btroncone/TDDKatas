using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDD.Katas.FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Will_Print_Fizz_When_Number_Is_Divisible_By_3(int numberToCheck)
        {
            var actual = FizzBuzz.FizzBuzzPrinter(numberToCheck);
            var expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Will_Print_Buzz_When_Number_Is_Divisible_By_5(int numberToCheck)
        {
            var actual = FizzBuzz.FizzBuzzPrinter(numberToCheck);
            var expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void Will_Print_FizzBuzz_When_Number_Is_Divisible_by_3_And_5(int numberToCheck)
        {
            var actual = FizzBuzz.FizzBuzzPrinter(numberToCheck);
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void Will_Return_Number_When_Number_Not_Divisible_By_3_Or_5(int numberToCheck)
        {
            var actual = FizzBuzz.FizzBuzzPrinter(numberToCheck);
            var expected = numberToCheck.ToString(CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(101)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Will_Throw_Exception_When_Number_Is_Out_Of_Range(int numberToCheck)
        {
            var actual = FizzBuzz.FizzBuzzPrinter(numberToCheck);
        }
        [Test]
        public void Will_Print_Numbers_1_100_Replacing_Appropriate_Numbers_With_Fizz_Buzz_FizzBuzz()
        {
            var actual = FizzBuzz.PrintNumbers();
            var expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";
            Assert.AreEqual(expected, actual);
        }
    }
}
