Feature: NotOperations
	In order to use boolean NOT operations
	As a client
	I want to be able to NOT a value

Scenario Outline: Boolean Not Operation 
	Given The input value <InputValue>
	When I request the result
	Then I should get the following <ExpectedValue>
Examples:
	| InputValue | ExpectedValue |
	| ¬T         | F             |
	| ¬F         | T             |