/*
================================================================================
TOPIC 3: COMMENTS - Documenting Your Code
================================================================================

WHAT IS THIS?
-------------
Comments are notes in your code that the compiler ignores. They're for humans
to read! Use them to explain what your code does, why you made certain decisions,
or to temporarily disable code while testing.

WHY DO WE NEED THIS?
--------------------
- Explain complex code - Help others (and yourself!) understand
- Document decisions - Why did you write it this way?
- Disable code - Comment out code to test alternatives
- Professional code - Well-commented code is easier to maintain
- Team collaboration - Others can understand your code faster

WHERE IS THIS USED?
-------------------
- Every professional codebase
- Complex algorithms - Explain the logic
- API documentation - Document method purposes
- TODO notes - Remind yourself of future work
- Debugging - Temporarily disable problematic code

CONCEPTS YOU'LL LEARN:
---------------------
1. Single-line comments: // comment
2. Multi-line comments: /* comment */
3. When to comment - Explain why, not what
4. Good vs bad comments
5. XML documentation comments (advanced)

================================================================================
*/

// Single-line Comments
// Single-line comments start with two forward slashes (//).

// Any text between // and the end of the line is ignored by C# (will not be executed).

// This example uses a single-line comment before a line of code:

// Example
// This is a comment
Console.WriteLine("Hello World!");

// This example uses a single-line comment at the end of a line of code:

// Example
Console.WriteLine("Hello World!");  // This is a comment

// C# Multi-line Comments
// Multi-line comments start with /* and ends with */.

// Any text between /* and */ will be ignored by C#.

// This example uses a multi-line comment (a comment block) to explain the code:

// Example
/* The code below will print the words Hello World
to the screen, and it is amazing */
Console.WriteLine("Hello World!"); 

// Single or multi-line comments?
// It is up to you which you want to use. Normally, we use // for short comments, and /* */ for longer.

/*
=== TOPIC 3 SUMMARY: COMMENTS ===
- Comments are for humans; the compiler ignores them.
- Single-line: // comment. Multi-line: /* comment ... */
- Use them to explain code or temporarily disable code. Use // for short notes and /* */ for longer blocks.
- Remember: Good comments make code easier to understand when you come back to it later.
*/