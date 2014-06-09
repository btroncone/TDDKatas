﻿using System;
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

        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        public void Will_Print_Fizz_For_Numbers_Divisible_By_3(int numberToCheck, string expectedResult)
        {
            var actual = FizzBuzz.FizzBuzzPrinter(numberToCheck);
            Assert.AreEqual(expectedResult, actual);
        }
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        public void Will_Print_Buzz_For_Numbers_Divisible_By_5(int numberToCheck, string expectedResult)
        {
            var actual = FizzBuzz.FizzBuzzPrinter(numberToCheck);
            Assert.AreEqual(expectedResult, actual);
        }
        [TestCase(15, "FizzBuzz")]
        [TestCase(60, "FizzBuzz")]
        public void Will_Print_FizzBuzz_For_Numbers_Divisible_By_3_And_5(int numberToCheck, string expectedResult)
        {
            var actual = FizzBuzz.FizzBuzzPrinter(numberToCheck);
            Assert.AreEqual(expectedResult, actual);
        }
        [Test]
        public void Will_Print_1_Through_100_And_Make_Correct_Replacements()
        {
            var actual = FizzBuzz.FizzBuzzPrinter();
            Assert.AreEqual(_expected, actual);
        }

        [TestCase(101)]
        [TestCase(0)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Will_Throw_Exception_When_Number_Out_Of_Bounds(int outOfBoundsNumber)
        {
            FizzBuzz.FizzBuzzPrinter(101);
        }

        
    }
}
