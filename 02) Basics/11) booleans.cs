/*
================================================================================
TOPIC 11: BOOLEANS - True/False Values
================================================================================

WHAT IS THIS?
-------------
Booleans represent true/false values. They're used for yes/no decisions, on/off
states, and conditions. Comparison operators (>, <, ==) return boolean values
that control program flow.

WHY DO WE NEED THIS?
--------------------
- Decision making - Control program flow (if statements)
- Conditions - Check if something is true or false
- Logic - Combine conditions with AND (&&), OR (||), NOT (!)
- Required for: if statements, loops, validation
- Foundation for: All conditional logic in programming

WHERE IS THIS USED?
-------------------
- If statements: if (age >= 18) { ... }
- Loops: while (condition) { ... }
- Validation: Check if input is valid
- Comparisons: Is user logged in? Is item in stock?
- Every program that makes decisions!

CONCEPTS YOU'LL LEARN:
---------------------
1. bool type - Stores true or false
2. Boolean expressions - Comparisons return bool
3. Comparison operators: ==, !=, >, <, >=, <=
4. Logical operators: && (AND), || (OR), ! (NOT)
5. Using booleans in conditions

================================================================================
*/

// C# Booleans
// Very often, in programming, you will need a data type that can only have one of two values, like:

// YES / NO
// ON / OFF
// TRUE / FALSE
// For this, C# has a bool data type, which can take the values true or false.

// Boolean Values
// A boolean type is declared with the bool keyword and can only take the values true or false:

// Example
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False

// However, it is more common to return boolean values from boolean expressions, for conditional testing (see below).

// Boolean Expression
// A Boolean expression returns a boolean value: True or False, by comparing values/variables.

// This is useful to build logic, and find answers.

// For example, you can use a comparison operator, such as the greater than (>) operator to find out if an expression (or a variable) is true:

// Example
int x = 10;
int y = 9;
Console.WriteLine(x > y); // returns True, because 10 is higher than 9

// Or even easier:

// Example
Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9

// In the examples below, we use the equal to (==) operator to evaluate an expression:

// Example
int x = 10;
Console.WriteLine(x == 10); // returns True, because the value of x is equal to 10

// Example
Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

// Real Life Example
// Let's think of a "real life example" where we need to find out if a person is old enough to vote.

// In the example below, we use the >= comparison operator to find out if the age (25) is greater than OR equal to the voting age limit, which is set to 18:

// Example
int myAge = 25;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);

// Cool, right? An even better approach (since we are on a roll now), would be to wrap the code above in an if...else statement, so we can perform different actions depending on the result:

// Example
// Output "Old enough to vote!" if myAge is greater than or equal to 18. Otherwise output "Not old enough to vote.":

int myAge = 25;
int votingAge = 18;

if (myAge >= votingAge) 
{
  Console.WriteLine("Old enough to vote!");
} 
else 
{
  Console.WriteLine("Not old enough to vote.");
}

/*
=== TOPIC 11 SUMMARY: BOOLEANS ===
- bool holds true or false. Used for yes/no, on/off, conditions. Boolean expressions: comparisons like x > y, x == 10 give true or false. Often used in if conditions (e.g. is age >= 18?).
- Remember: Comparison operators (==, !=, >, <) return a bool. Logical operators (&&, ||, !) combine bools.
*/

