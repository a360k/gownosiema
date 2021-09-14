Feature: Calculator

@mytag
Scenario Outline: Add two numbers
	Given the first '<a>' number is '<b>'

	Examples: 
	| a | b  |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |
	| 5 | 55 |

@mytag
Scenario Outline: Multiple two numbers
	Given '<a>' multiplied by '<b>' number is '<c>'

	Examples: 
	| a | b  | c |
	| 5 | 3 |  15 |
	| 3| 15 |45   |
	| 5 | 10 | 50  |
	| 2 | 4 |  8 |