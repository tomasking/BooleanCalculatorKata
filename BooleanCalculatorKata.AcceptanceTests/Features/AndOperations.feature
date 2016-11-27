Feature: AndOperations
	In order to use boolean AND operations
	As a client
	I want to be able to AND a value

Scenario Outline: Boolean AND Operation 
	Given The input value <InputValue>
	When I request the result
	Then I should get the following <ExpectedValue>
Examples:
	| InputValue      | ExpectedValue |
	| TRUE AND TRUE   | true          |
	| TRUE AND FALSE  | false         |
	| FALSE AND TRUE  | false         |
	| FALSE AND FALSE | false         |