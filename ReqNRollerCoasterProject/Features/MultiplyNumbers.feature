Feature: MultiplyNumbers
  As a user
  I want to multiply two numbers
  So that I can get the result

Simple calculator for multiplying two numbers

Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are Multiplied
	Then the result should be 3500

Scenario: Multiply a negative numbers
	Given the first number is -7
	And the second number is 53
	When the two numbers are Multiplied
	Then the result should be -371

  Scenario: Multiply two other numbers
	Given the first number is 12
	And the second number is 17
	When the two numbers are Multiplied
	Then the result should be 204