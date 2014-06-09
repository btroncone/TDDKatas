using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TDD.Katas.FizzBuzz
{
    [Binding]
    public class FizzBuzzFeatureSteps
    {
        private string _result;
        [Given(@"there is a FizzBuzz class")]
        public void GivenThereIsAFizzBuzzClass()
        {

        }

        [When(@"the number (.*) is passed to the FizzBuzzPrinter")]
        public void WhenTheNumberIsPassedToTheFizzBuzzPrinter(int numberToCheck)
        {
            _result = FizzBuzz.FizzBuzzPrinter(numberToCheck);
        }

        [When(@"the number (.*) is passed into the FizzBuzzPrinter")]
        public void WhenTheNumberIsPassedIntoTheFizzBuzzPrinter(int numberToCheck)
        {
            _result = FizzBuzz.FizzBuzzPrinter(numberToCheck);
        }

        [Then(@"the number should be changed to FizzBuzz")]
        public void ThenTheNumberShouldBeChangedToFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _result);
        }

        [Then(@"the number should be changed to Fizz")]
        public void ThenTheNumberShouldBeChangedToFizz()
        {
            Assert.AreEqual("Fizz", _result);
        }

        [Then(@"the number should be changed to Buzz")]
        public void ThenTheNumberShouldBeChangedToBuzz()
        {
            Assert.AreEqual("Buzz", _result);
        }
    }
}
