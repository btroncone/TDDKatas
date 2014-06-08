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

        [Test]
        public void Will_Print_Numbers_1_To_100_With_Fizz_Buzz_Correctly_Inserted()
        {
            string fizzBuzzResult = FizzBuzz.NumberPrinter();
            Assert.AreEqual(_expected, fizzBuzzResult);
        }
        [TestCase(3, true)]
        [TestCase(99, true)]
        [TestCase(5, false)]
        [TestCase(100, false)]
        public void Will_Return_True_If_Divisible_By_Three(int numberToCheck, bool isFizz)
        {
            bool fizzTest = FizzBuzz.IsFizz(numberToCheck);
            Assert.AreEqual(isFizz, fizzTest);
        }
        [TestCase(5, true)]
        [TestCase(100, true)]
        [TestCase(3, false)]
        [TestCase(99, false)]
        public void Will_Return_True_If_Divisible_By_Five(int numberToCheck, bool isBuzz)
        {
            bool buzzTest = FizzBuzz.IsBuzz(numberToCheck);
            Assert.AreEqual(isBuzz, buzzTest);
        }

        
    }
}
