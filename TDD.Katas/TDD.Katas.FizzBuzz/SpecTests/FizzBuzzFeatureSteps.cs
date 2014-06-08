using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TDD.Katas.FizzBuzz.SpecTests
{
    [Binding]
    public class FizzBuzzFeatureSteps
    {
        private bool _expected;

        [Given(@"there is a FizzBuzz class")]
        public void GivenThereIsAFizzBuzzClass()
        {
            
        }

        [When(@"the number (.*) is passed to the IsFizz method")]
        public void WhenTheNumberIsPassedToTheIsFizzMethod(int numberToCheck)
        {
            _expected = FizzBuzz.IsFizz(numberToCheck);
        }

        [When(@"the number (.*) is passed to the IsBuzz method")]
        public void WhenTheNumberIsPassedToTheIsBuzzMethod(int numberToCheck)
        {
            _expected = FizzBuzz.IsBuzz(numberToCheck);
        }

        [Then(@"the IsFizz method should return TRUE")]
        public void ThenTheIsFizzMethodShouldReturnTRUE()
        {
            Assert.AreEqual(true, _expected);
        }

        [Then(@"the IsBuzz method should return TRUE")]
        public void ThenTheIsBuzzMethodShouldReturnTRUE()
        {
            Assert.AreEqual(true, _expected);
        }

        [Then(@"the IsFizz method should return FALSE")]
        public void ThenTheIsFizzMethodShouldReturnFALSE()
        {
            Assert.AreEqual(false, _expected);
        }

        [Then(@"the IsBuzz method should return FALSE")]
        public void ThenTheIsBuzzMethodShouldReturnFALSE()
        {
            Assert.AreEqual(false, _expected);
        }
    }
}
