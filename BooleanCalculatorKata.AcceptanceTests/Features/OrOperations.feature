Feature: OrOperations
	In order to use boolean OR operations
	As a client
	I want to be able to OR a value

Scenario Outline: Boolean OR Operation 
	Given The input value <InputValue>
	When I request the result
	Then I should get the following <ExpectedValue>
Examples:
	| InputValue     | ExpectedValue |
	| TRUE OR TRUE   | true          |
	| TRUE OR FALSE  | true          |
	| FALSE OR TRUE  | true          |
	| FALSE OR FALSE | false         |