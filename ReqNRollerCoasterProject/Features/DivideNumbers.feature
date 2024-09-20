@demo
Feature: DivideNumbers
  As a user
  I want to divide two numbers
  So that I can get the result

Simple calculator for divide two numbers

Scenario: Divide two numbers
	Given the first number is 100
	And the second number is 20
	When the two numbers are divided
	Then the result should be 5

Scenario: Divide a negative numbers
	Given the first number is 192
	And the second number is 32
	When the two numbers are divided
	Then the result should be 6

  Scenario: Divide two other numbers
	Given the first number is 60
	And the second number is 12
	When the two numbers are divided
	Then the result should be 5