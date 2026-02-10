/*
================================================================================
TOPIC 12: IF STATEMENTS - Making Decisions
================================================================================

WHAT IS THIS?
-------------
If statements let your program make decisions. They execute code only when a
condition is true. This is how programs respond differently to different situations.

WHY DO WE NEED THIS?
--------------------
- Decision making - Execute code based on conditions
- User input validation - Check if input is valid
- Business logic - Different actions for different cases
- Control flow - Most important concept in programming
- Required for: Every program that needs to make decisions

WHERE IS THIS USED?
-------------------
- User validation: if (age >= 18) { allow access }
- Error handling: if (error) { show message }
- Feature toggles: if (featureEnabled) { show feature }
- Business rules: if (balance > 0) { allow withdrawal }
- Every application!

CONCEPTS YOU'LL LEARN:
---------------------
1. if statement - Execute code when condition is true
2. else statement - Execute code when condition is false
3. else if - Check multiple conditions
4. Nested if statements
5. Combining conditions with && and ||

================================================================================
*/

// C# Conditions and If Statements
// You already know that C# supports familiar comparison conditions from mathematics, such as:

// Less than: a < b
// Less than or equal to: a <= b
// Greater than: a > b
// Greater than or equal to: a >= b
// Equal to a == b
// Not Equal to: a != b
// You can use these conditions to perform different actions for different decisions.

// C# has the following conditional statements:

// Use if to specify a block of code to be executed, if a specified condition is true
// Use else to specify a block of code to be executed, if the same condition is false
// Use else if to specify a new condition to test, if the first condition is false
// Use switch to specify many alternative blocks of code to be executed
// The if Statement
// Use the if statement to specify a block of C# code to be executed if a condition is True.

// Syntax
// if (condition) 
// {
//   // block of code to be executed if the condition is True
// }
// Note that if is in lowercase letters. Uppercase letters (If or IF) will generate an error.

// In the example below, we test two values to find out if 20 is greater than 18. If the condition is True, print some text:

// Example
if (20 > 18) 
{
  Console.WriteLine("20 is greater than 18");
}

// We can also test variables:

// Example
int x = 20;
int y = 18;
if (x > y) 
{
  Console.WriteLine("x is greater than y");
}

/*
=== TOPIC 12 SUMMARY (IF/ELSE): IF ===
- if: run a block only when condition is true: if (condition) { ... }.
- Remember: Use lowercase if. Condition in parentheses; block in curly braces.
*/

// Example explained
// In the example above we use two variables, x and y, to test whether x is greater than y (using the > operator). As x is 20, and y is 18, and we know that 20 is greater than 18, we print to the screen that "x is greater than y".