/*
================================================================================
TOPIC 4: VARIABLES - Storing Data
================================================================================

WHAT IS THIS?
-------------
Variables are containers that store data values. They have a name, a type, and
a value. You use variables to store information your program needs to work with.

WHY DO WE NEED THIS?
--------------------
- Store data - Keep values for later use
- Calculations - Store results of operations
- User input - Store what user enters
- State management - Track program state
- Foundation - Everything in programming uses variables

WHERE IS THIS USED?
-------------------
- Every program - All code uses variables
- User data: name, age, email
- Calculations: total, average, result
- Game state: score, health, level
- Configuration: settings, preferences

CONCEPTS YOU'LL LEARN:
---------------------
1. Variable declaration - type name = value
2. Variable types - int, string, bool, etc.
3. Variable naming - Rules and best practices
4. Assigning values - Change variable values
5. Constants - Values that don't change

================================================================================
*/

// C# Variables
// Variables are containers for storing data values.

// In C#, there are different types of variables (defined with different keywords), for example:

// int - stores integers (whole numbers), without decimals, such as 123 or -123
// double - stores floating point numbers, with decimals, such as 19.99 or -19.99
// char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
// string - stores text, such as "Hello World". String values are surrounded by double quotes
// bool - stores values with two states: true or false
// Declaring (Creating) Variables
// To create a variable, specify the type and assign it a value:

// Syntax
// type variableName = value;
// Where type is a C# type (such as int or string), and variableName is the name of the variable (such as x or name). The equal sign is used to assign values to the variable.

// To create a variable that should store text, look at the following example:

// Example
// Create a variable called name of type string and assign it the value "John":
string name = "John";
Console.WriteLine(name);

// To create a variable that should store a number, look at the following example:

// Example
// Create a variable called myNum of type int and assign it the value 15:

int myNum = 15;
Console.WriteLine(myNum);

// You can also declare a variable without assigning the value, and assign the value later:

// Example
int myNum;
myNum = 15;
Console.WriteLine(myNum);

// Note that if you assign a new value to an existing variable, it will overwrite the previous value:

// Example
// Change the value of myNum to 20:

int myNum = 15;
myNum = 20; // myNum is now 20
Console.WriteLine(myNum);

// Other Types
// A demonstration of how to declare variables of other types:

// Example
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

/*
=== TOPIC 4 SUMMARY (VARIABLES): VARIABLES ===
- Variables store data. Declare with type and name: type variableName = value;
- Main types: int (whole numbers), double (decimals), char (single character, single quotes), string (text, double quotes), bool (true/false).
- You can declare first and assign later. Assigning again overwrites the value.
- Remember: char uses single quotes 'A', string uses double quotes "Hello".
*/