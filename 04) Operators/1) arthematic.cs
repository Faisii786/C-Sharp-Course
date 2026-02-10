/*
================================================================================
TOPIC 8: OPERATORS - Performing Operations
================================================================================

WHAT IS THIS?
-------------
Operators perform operations on variables and values. Arithmetic operators do
math (+, -, *, /), comparison operators compare values (>, <, ==), and logical
operators combine conditions (&&, ||, !).

WHY DO WE NEED THIS?
--------------------
- Calculations - Perform math operations
- Comparisons - Compare values for decisions
- Logic - Combine conditions
- Required for: All programming logic
- Foundation - Used in every program

WHERE IS THIS USED?
-------------------
- Calculations: total = price * quantity
- Comparisons: if (age >= 18)
- Logic: if (isLoggedIn && hasPermission)
- Incrementing: counter++
- Every program uses operators!

CONCEPTS YOU'LL LEARN:
---------------------
1. Arithmetic: +, -, *, /, % (modulus)
2. Assignment: =, +=, -=, *=, /=
3. Comparison: ==, !=, >, <, >=, <=
4. Logical: && (AND), || (OR), ! (NOT)
5. Increment/Decrement: ++, --

================================================================================
*/

// Operators
// Operators are used to perform operations on variables and values.

// In the example below, we use the + operator to add together two values:

// Example
int x = 100 + 50;

// Although the + operator is often used to add together two values, like in the example above, it can also be used to add together a variable and a value, or a variable and another variable:

// Example
int sum1 = 100 + 50;        // 150 (100 + 50)
int sum2 = sum1 + 250;      // 400 (150 + 250)
int sum3 = sum2 + sum2;     // 800 (400 + 400)

// Arithmetic Operators
// Arithmetic operators are used to perform common mathematical operations:

// Operator	Name	Description	Example	Try it
// +	Addition	Adds together two values	x + y	
// -	Subtraction	Subtracts one value from another	x - y	
// *	Multiplication	Multiplies two values	x * y	
// /	Division	Divides one value by another	x / y	
// %	Modulus	Returns the division remainder	x % y	
// ++	Increment	Increases the value of a variable by 1	x++	
// --	Decrement	Decreases the value of a variable by 1	x--	

/*
=== TOPIC 8 SUMMARY (OPERATORS): ARITHMETIC ===
- + add, - subtract, * multiply, / divide, % remainder, ++ increment by 1, -- decrement by 1.
- Remember: int / int = int (e.g. 7/2 = 3). % gives remainder (e.g. 7%2 = 1). x++ is same as x = x + 1.
*/
