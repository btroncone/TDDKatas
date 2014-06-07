using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDD.Katas.FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private string _expected;
        [SetUp]
        public void Setup()
        {
            _expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz"; 
        }

        [Test]
        public void Will_Print_Fizz_For_3_Buzz_For_5_FizzBuzz_For_Both()
        {

            var actualFizzBuzzResult = FizzBuzz.PrintNumbers();
            Assert.AreEqual(_expected, actualFizzBuzzResult);
        }

        [TestCase(1)]
        [TestCase(100)]
        [TestCase(50)]
        public void Is_Number_Between_1_And_100(int numberToCheck)
        {
            var actualNumberCheckResult = FizzBuzz.NumberChecker(numberToCheck);
            Assert.True(actualNumberCheckResult);
        }

        [TestCase(0)]
        [TestCase(101)]
        public void Is_Number_Out_Of_Fizz_Buzz_Bounds(int numberToCheck)
        {
            var actualNumberCheckResult = FizzBuzz.NumberChecker(numberToCheck);
            Assert.False(actualNumberCheckResult);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(12)]
        public void Is_Number_Fizz(int numberToCheck)
        {
            var actualResult = FizzBuzz.FizzBuzzChecker(numberToCheck).Trim();
            var expectedResult = "Fizz";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Is_Number_Buzz(int numberToCheck)
        {
            var actualResult = FizzBuzz.FizzBuzzChecker(numberToCheck).Trim();
            var expectedResult = "Buzz";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void Is_Number_FizzBuzz(int numberToCheck)
        {
            var actualResult = FizzBuzz.FizzBuzzChecker(numberToCheck).Trim();
            var expectedResult = "FizzBuzz";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase]
        [TestCase(101)]
        [TestCase(0)]
        public void Is_Number_Neither_Fizz_Nor_Buzz(int numberToCheck)
        {
            var actualResult = FizzBuzz.FizzBuzzChecker(numberToCheck);
            var expectedResult = String.Empty;
            Assert.AreEqual(expectedResult,actualResult);

        }
        
    }
}
