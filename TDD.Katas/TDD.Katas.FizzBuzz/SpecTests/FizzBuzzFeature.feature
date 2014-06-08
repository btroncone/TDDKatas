Feature: FizzBuzzFeature
	In order to learn SpecFlow
	And improve in TDD and BDD
	I want to complete the FizzBuzz TDD Kata
	
@mytag
Scenario: Return TRUE when the number is divisible by 3
	Given there is a FizzBuzz class
	When  the number 3 is passed to the IsFizz method
	Then  the IsFizz method should return TRUE

@mytag
Scenario: Return TRUE when the number is divisible by 5
	Given there is a FizzBuzz class
	When  the number 5 is passed to the IsBuzz method
	Then  the IsBuzz method should return TRUE

@mytag
	Scenario: Return FALSE when the number is not divisible by 3
	Given there is a FizzBuzz class
	When  the number 5 is passed to the IsFizz method
	Then  the IsFizz method should return FALSE

@mytag
	Scenario: Return FALSE when the number is not divisible by 5
	Given there is a FizzBuzz class
	When  the number 3 is passed to the IsBuzz method
	Then  the IsBuzz method should return FALSE
