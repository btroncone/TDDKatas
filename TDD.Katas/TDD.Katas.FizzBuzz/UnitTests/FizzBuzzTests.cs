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
        
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Will_Print_Fizz_If_Number_Is_Divisible_By_3(int numberToCheck)
        {
            const string expected = "Fizz";
            var actual = FizzBuzz.GetFizzBuzz(numberToCheck);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5)]
        [TestCase(20)]
        [TestCase(100)]
        public void Will_Print_Fizz_If_Number_Is_Divisible_By_5(int numberToCheck)
        {
            const string expected = "Buzz";
            var actual = FizzBuzz.GetFizzBuzz(numberToCheck);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void Will_Print_FizzBuzz_If_Number_Is_Divisible_By_3_And_5(int numberToCheck)
        {
            const string expected = "FizzBuzz";
            var actual = FizzBuzz.GetFizzBuzz(numberToCheck);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Will_Print_Numbers_1_100_Inserting_Fizz_And_Buzz_Appropriately()
        {
            var fizzBuzzActualResult = FizzBuzz.GetFizzBuzz();
            Assert.AreEqual(_expected, fizzBuzzActualResult);
        }

        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        [TestCase(0)]
        [TestCase(101)]
        public void Will_Throw_Exception_If_Number_Is_Less_Than_1_Or_Greater_Than_100(int numberToCheck)
        {
            FizzBuzz.GetFizzBuzz(numberToCheck);
        }
        
    }
}
