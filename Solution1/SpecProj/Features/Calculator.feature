Feature: Calculator

@first
Scenario Outline: Add two numbers
	Given the first '<a>' number is '<b>'

	Examples: 
	| a | b  |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |

@first
Scenario Outline: Multiple two numbers
	Given '<a>' multiplied by '<b>' number is '<c>'

	Examples: 
	| a | b  | c |
	| 5 | 3 |  15 |
	| 3| 15 |45   |
	| 5 | 10 | 50  |
	| 2 | 4 |  1 |

@first
Scenario Outline: Add two numbers 2
	Given the first '<a>' number is '<b>'

	Examples: 
	| a | b  |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |