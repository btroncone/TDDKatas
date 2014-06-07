using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TDD.Katas.FizzBuzz.SpecTests
{
    [Binding]
    public class FizzBuzzFeatureSteps
    {
        private string actualResult;

        [Given(@"there is a FizzBuzz class")]
        public void GivenThereIsAFizzBuzzClass()
        {
            
        }

        [When(@"the number (.*) is passed to the FizzBuzzChecker")]
        public void WhenTheNumberIsPassedToTheFizzBuzzChecker(int numberToCheck)
        {
            actualResult = FizzBuzz.FizzBuzzChecker(numberToCheck);
        }

        [Then(@"the number should be replaced by Fizz")]
        public void ThenTheNumberShouldBeReplacedByFizz()
        {
            Assert.AreEqual("Fizz", actualResult.Trim());
        }

        [Then(@"the number should be replaced by Buzz")]
        public void ThenTheNumberShouldBeReplacedByBuzz()
        {
            Assert.AreEqual("Buzz", actualResult.Trim());
        }

        [Then(@"the number should be replaced by FizzBuzz")]
        public void ThenTheNumberShouldBeReplacedByFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", actualResult.Trim());
        }

        [Then(@"the number should be replaced by an empty string")]
        public void ThenTheNumberShouldBeReplacedByAnEmptyString()
        {
            Assert.AreEqual(string.Empty, actualResult);
        }



    }
}
