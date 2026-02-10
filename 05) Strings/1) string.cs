/*
================================================================================
TOPIC 10: STRINGS - Working with Text
================================================================================

WHAT IS THIS?
-------------
Strings store text - sequences of characters. C# provides many methods to
manipulate strings: find length, convert case, search, replace, and more.

WHY DO WE NEED THIS?
--------------------
- Text processing - Most programs work with text
- User input - Names, addresses, messages are strings
- Data formatting - Format numbers, dates as strings
- Validation - Check if strings match patterns
- Required for: Almost every application

WHERE IS THIS USED?
-------------------
- User input: Names, emails, addresses
- Display: Messages, labels, descriptions
- Data processing: Parse CSV, JSON, XML
- Validation: Check email format, password strength
- Every application that handles text!

CONCEPTS YOU'LL LEARN:
---------------------
1. String creation - "text" or string variable
2. String methods - Length, ToUpper(), ToLower()
3. String concatenation - Combine strings (+)
4. String interpolation - $"Hello {name}"
5. String methods - IndexOf(), Substring(), Replace()

================================================================================
*/

// C# Strings
// Strings are used for storing text.

// A string variable contains a collection of characters surrounded by double quotes:

// Example
// Create a variable of type string and assign it a value:

string greeting = "Hello";

// A string variable can contain many words, if you want:

// Example
string greeting2 = "Nice to meet you!";

// String Length
// A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings. For example, the length of a string can be found with the Length property:

// Example
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

// Other Methods
// There are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:

// Example
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"

/*
=== TOPIC 10 SUMMARY (STRINGS): STRINGS ===
- Strings store text in double quotes. Length: stringName.Length. Methods: ToUpper(), ToLower() return new string in upper/lowercase.
- Remember: Strings are immutable — ToUpper()/ToLower() return a new string; they don't change the original.
*/
