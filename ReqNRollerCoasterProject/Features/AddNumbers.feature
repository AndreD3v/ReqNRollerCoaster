@demo
Feature: AddNumbers
  As a user
  I want to add two numbers
  So that I can get the result

Simple calculator for adding two numbers

Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Add a negative numbers
	Given the first number is -7
	And the second number is 53
	When the two numbers are added
	Then the result should be 46

  Scenario: Add two other numbers
	Given the first number is 12
	And the second number is 17
	When the two numbers are added
	Then the result should be 29