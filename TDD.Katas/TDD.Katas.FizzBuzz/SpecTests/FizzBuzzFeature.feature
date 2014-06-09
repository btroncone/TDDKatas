Feature: FizzBuzzFeature
	In order to learn SpecFlow
	And improve in TDD and BDD
	I want to complete the FizzBuzz TDD Kata
	
@mytag
Scenario: Return FizzBuzz when number is divisible by 3 & 5
	Given there is a FizzBuzz class
	When  the number 15 is passed to the FizzBuzzPrinter
	Then  the number should be changed to FizzBuzz

@mytag
Scenario: Return Fizz when number is divisible by 3
	Given there is a FizzBuzz class
	When  the number 3 is passed to the FizzBuzzPrinter
	Then  the number should be changed to Fizz

@mytag
	Scenario: Return Buzz when number is divisible by 5
	Given there is a FizzBuzz class
	When  the number 5 is passed into the FizzBuzzPrinter
	Then  the number should be changed to Buzz

