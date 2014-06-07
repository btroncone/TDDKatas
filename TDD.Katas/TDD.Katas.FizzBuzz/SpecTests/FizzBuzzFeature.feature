Feature: FizzBuzzFeature
	In order to learn SpecFlow
	And improve in TDD and BDD
	I want to complete the FizzBuzz TDD Kata
	
@mytag
Scenario: Print "Fizz" instead of number which is divisible by 3
	Given there is a FizzBuzz class
	When  the number 3 is passed to the FizzBuzzChecker
	Then  the number should be replaced by Fizz

@mytag
Scenario: Print "Buzz" instead of number which is divisible by 5
	Given there is a FizzBuzz class
	When  the number 5 is passed to the FizzBuzzChecker
	Then  the number should be replaced by Buzz

@mytag
Scenario: Print "FizzBuzz" instead of number which is divisible by 3 and 5
	Given there is a FizzBuzz class
	When  the number 15 is passed to the FizzBuzzChecker
	Then  the number should be replaced by FizzBuzz

@mytag
Scenario: Print nothing when the number is invalid
	Given there is a FizzBuzz class
	When  the number 101 is passed to the FizzBuzzChecker
	Then  the number should be replaced by an empty string
